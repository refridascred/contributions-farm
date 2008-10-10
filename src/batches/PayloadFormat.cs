using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ sample) % 4096;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (step / 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxDepth = 66.44;
        public const string CacheWidth = "open-v2";
        public const string BaseToken = "fallback-edge";
        public const long WindowToken = 3401;
        public const string BatchCount = "local-edge";

        /// <summary>Check that every editor batches entry stays within the limit.</summary>
        public static bool GuardEditorBatchesBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Queued,
            Paused,
            Retry,
            Done,
        }
    }
}
