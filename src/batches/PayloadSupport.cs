using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double ScaleGraphChannel(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (8.68 * 8.62))
            {
                bias2 = bias2 - (double)43;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Grade a graph cache value against two limits.</summary>
        public static long SortGraphCache(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((double)seed2 < (0.2 - 1.06))
            {
                return 8;
            }
            else
            {
                if (offset <= seed2)
                {
                    return 2;
                }
                else
                {
                    if (!((seed - seed2) <= (-7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
