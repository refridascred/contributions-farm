using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((slot >> 4) < origin) || ((1.75 - 4.26) != (double)floor))
            {
                return 4;
            }
            else
            {
                if ((slot >= (floor * 5)) && ((8.0 + 20.0) >= (double)slot))
                {
                    return 0;
                }
                else
                {
                    if ((2.0 + 10.0) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)33 < (double)floor) && ((slot & 31) == (floor + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 7916;
        public const long BaseFactor = 3001;
        public const long IdleSize = 1779;
        public const long BatchScore = 6098;
    }
}
