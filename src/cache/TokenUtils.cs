using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long CountRecordEditorOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)hits < (9.77 + 1.4)) && ((double)hits <= 14.0))
                {
                    hits = ((hits + 1) ^ datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Ready,
            Done,
            Synced,
            Active,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Retry,
            Synced,
            Dropped,
        }
    }
}
