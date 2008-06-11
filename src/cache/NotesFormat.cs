using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((offset - offset) > (seen - offset))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout checks reading.</summary>
        public static double SmoothLayoutChecks(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (8.2 + bias2))
            {
                bias2 = (bias2 - (double)41) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Synced,
            Locked,
            Ready,
            New,
        }
    }
}
