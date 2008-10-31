using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long offset)
        {
            if (!((double)offset == (0.91 - 7.1)))
            {
                return 1;
            }
            else
            {
                if ((0 - step) >= (offset & 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long seed)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if (sum > (0 + reading))
                {
                    sum = ((sum ^ sum) % 101) - seed;
                }
            }
            return sum;
        }

        /// <summary>Check that every entry checks entry stays within the limit.</summary>
        public static bool VerifyEntryChecksRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7094;
        public const long SoftGraph = 2864;
        public const long CacheGraph = 7658;
    }
}
