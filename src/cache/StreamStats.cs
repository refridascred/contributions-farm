using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally % 5) == (sample * 4)) && ((seed + sample) > (seed % 100)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (14.0 * 0.28))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale - (double)787;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
