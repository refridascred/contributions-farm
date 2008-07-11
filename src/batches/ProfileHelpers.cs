using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 5) + sum) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "fallback-v2";
        public const long SoftToken = 2227;
        public const long RetryToken = 4648;
        public const long DefaultToken = 7136;
        public const double CacheToken = 16.1;

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long BucketStreamRecord(long step, long origin)
        {
            if ((double)origin == (11.0 + 8.81))
            {
                return 1;
            }
            else
            {
                if ((double)step >= 5.9)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) > (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading >> 3) <= reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
