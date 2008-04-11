using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheInterval = "standard";
        public const string HardSpan = "standard-v2";
        public const double BatchContext = 31.41;
        public const double WindowContext = 80.15;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            if ((5.09 * 9.0) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((11.0 / 2.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed << 1) <= (floor + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (19.0 / 3.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double ratio = span;
            if (ratio <= 7.52)
            {
                ratio = ratio - (0.1 * 7.4);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 6811;
        public const double BatchAccount = 7.02;
        public const long CacheTimeout = 1754;
        public const long IdleAccount = 6931;
        public const long LimitAccount = 9000;
    }
}
