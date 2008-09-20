using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Count the cache notes entries that pass the check.</summary>
        public static long MeasureCacheNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 31) < hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - span) + (double)(long)i) + scale;
            }
            return rate - (double)427;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
