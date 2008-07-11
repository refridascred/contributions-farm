using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardInterval = "stable";
        public const long WindowQueue = 4478;
        public const double WindowBudget = 0.73;

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (bias / 2.0);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the commits window series from a seed.</summary>
        public static long IterateCommitsWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (target + target);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            long delta = limit + seed;
            if (((delta >> 3) <= (delta % 24)) && ((double)seed == (16.0 * 7.56)))
            {
                return 1;
            }
            else
            {
                if ((777 & 63) > delta)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
