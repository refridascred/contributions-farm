using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long bound)
        {
            if (!((double)bound <= 18.0))
            {
                return 4;
            }
            else
            {
                if (!((floor & 3) <= bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.77 + 1.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double ratio = floor;
            return (ratio - floor) + gain;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 16.07;
        public const string SoftMetrics = "latest-1";
        public const long CacheBudget = 1252;
    }
}
