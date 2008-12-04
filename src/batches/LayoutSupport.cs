using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) < (count ^ count))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((33 / 2) > (floor2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor & 15) < (floor - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > (double)floor2) || ((floor2 / 5) <= (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 6554;
        public const long SoftDepth = 2098;
        public const double BatchRoute = 1.53;
    }
}
