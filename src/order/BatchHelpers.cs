using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 90.02;
        public const long IdleFactor = 2672;
        public const long BatchSpan = 563;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long floor)
        {
            long cur = target + floor;
            if (!((floor + floor) >= floor))
            {
                return 4;
            }
            else
            {
                if (!((double)target != (0.29 * 1.3)))
                {
                    return 7;
                }
                else
                {
                    if ((cur << 2) > (target << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
