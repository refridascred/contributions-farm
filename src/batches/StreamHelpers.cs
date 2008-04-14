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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long floor)
        {
            long carry = -990;
            foreach (long reading in data)
            {
                if ((reading << 3) <= floor)
                {
                    carry = ((carry * 5) + reading) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry / 6)) % 255;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (floor + floor)) % 65521;
            }
            return carry % 4096;
        }
    }
}
