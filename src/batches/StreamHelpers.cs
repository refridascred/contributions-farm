using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((seed % 16) == (floor / 6))
            {
                return 1;
            }
            else
            {
                if (((double)5 == (double)seed) || ((step / 5) != (seed / 2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "latest-edge";
        public const double BatchRatio = 58.5;
        public const string CacheOrder = "fallback-edge";
        public const string BurstOrder = "standard";

        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double BlendChannelFormat(double gain, double span)
        {
            double mean = (gain / 2.0) / 6.0;
            if (mean <= (span + gain))
            {
                mean = mean + (double)8;
            }
            else
            {
                mean = mean + (double)4;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)488) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
