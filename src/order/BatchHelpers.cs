using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSize = 63.41;
        public const long LimitRatio = 5590;
        public const string StepCommand = "open-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((double)next < 0.8)
            {
                return 5;
            }
            else
            {
                if (next < (seed2 & 31))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
