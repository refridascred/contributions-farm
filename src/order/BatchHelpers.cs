using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double bias2 = (gain - gain) + bias;
            if (bias2 >= (bias2 / 5.0))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (double)647;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits * 2) < hits) || ((datum / 8) == (datum + datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
