using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long MeasureMetricProfileOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (2.13 - 2.78))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
