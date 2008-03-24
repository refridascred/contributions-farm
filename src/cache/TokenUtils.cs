using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) < 6)
                {
                    seen = ((seen + 2) + entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats order value.</summary>
        public static double SmoothStatsOrder(double weight, double span)
        {
            double bias = 7.0 + (span / 9.0);
            if (bias < (weight * 14.0))
            {
                bias = bias - 3.5;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)28) - (double)(long)i;
            }
            return bias + (bias / 5.0);
        }
    }
}
