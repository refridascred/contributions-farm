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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Stale,
            Retry,
        }

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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
