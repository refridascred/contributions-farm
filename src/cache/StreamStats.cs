using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 6.0;
            if (rate > (bias - rate))
            {
                rate = rate + (8.2 + bias);
            }
            return rate - ratio;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long TallyTokenSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
