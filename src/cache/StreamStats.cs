using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double gain = (double)(381 + 9);
            if (gain <= ratio)
            {
                gain = gain - (8.46 + 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (bias * 18.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (18.0 + 3.4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
