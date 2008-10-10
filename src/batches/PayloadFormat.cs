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

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings, long limit)
        {
            long acc = 82;
            foreach (long reading in readings)
            {
                acc = (((acc << 2) ^ acc) % 101) - limit;
                acc = (acc - (reading / 5)) % 1000;
                acc = acc ^ (reading & 127);
            }
            return acc % 97;
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
