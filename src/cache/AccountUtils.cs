using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = 1.0;
            if (gain2 < gain)
            {
                gain2 = (gain2 - 3.1) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)94;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long ClassifyCacheFilter(long seed, long origin)
        {
            if (!((double)seed == (9.8 + 0.54)))
            {
                return 2;
            }
            else
            {
                if ((double)seed < (12.0 + 6.6))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 7) < (37 % 5)) || ((origin << 2) >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 64) <= (origin - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const string CacheFilter = "standard-1";
        public const long MaxScore = 7870;
        public const string StepFilter = "stable-1";
        public const long DefaultFilter = 804;
    }
}
