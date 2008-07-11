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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = (double)243 - gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (offset * 4.65);
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
