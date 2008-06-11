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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double rate = (bias - 19.0) / 9.0;
            if (rate <= (double)(-59))
            {
                rate = rate - (bias - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 13.0)) + (double)(long)i;
            }
            return rate + (bias / 3.0);
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
