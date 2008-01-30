using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = sum + ((long)i << 1);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double ratio, double floor)
        {
            double rate = (floor + floor) - (ratio / 7.0);
            if (rate > (floor + 0.96))
            {
                rate = rate + (double)476;
            }
            else
            {
                rate = rate - (rate - floor);
            }
            return rate + (double)1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
