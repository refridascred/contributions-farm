using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + count) < (count % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
