using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits > item) || ((item ^ hits) > (hits + 960))) && (((hits / 5) != (14 / 6)) || ((hits & 1) == (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter payload reading.</summary>
        public static double SmoothCounterPayload(double weight, double offset)
        {
            double mean = (double)((-2) >> 2);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)54) - (double)(long)i) + weight;
            }
            return mean + offset;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Idle,
            Pending,
            New,
        }
    }
}
