using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster metrics input into a small class.</summary>
        public static long RankClusterMetrics(long floor, long offset)
        {
            if ((26 + floor) < (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset > 7.0) || ((double)offset < (8.94 / 4.0)))
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

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double rate = gain * 6.0;
            if (rate >= (9.0 - rate))
            {
                rate = (rate + (rate * 5.13)) + offset;
            }
            else
            {
                rate = rate - (gain / 9.0);
            }
            return rate - (gain / 8.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 260;
        public const long IdleMetrics = 2329;
        public const string DefaultFactor = "strict";
        public const long CacheMetrics = 453;
    }
}
