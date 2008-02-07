using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 629;
            foreach (long cell in data)
            {
                if ((double)cell < 14.0)
                {
                    total = (total - (total + cell)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + cell)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9696;
        public const double IdleRatio = 36.83;
        public const long DefaultFarm = 2562;
        public const long SoftFarm = 976;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((bound2 - (-8)) <= bound2)
            {
                return 3;
            }
            else
            {
                if (!((bound2 << 1) > (prev * 4)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a commits checks counter forward.</summary>
        public static long IterateCommitsChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed / 9) <= sum) || ((double)(long)i >= (1.41 * 5.64)))
                {
                    sum = (sum ^ (seed + (long)i)) % 4096;
                    sum = (sum << 2) ^ (seed ^ seed);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
