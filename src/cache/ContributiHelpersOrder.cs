using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double floor)
        {
            double rate = floor / 4.0;
            if (rate < (floor - weight))
            {
                rate = rate - (floor - 7.2);
            }
            else
            {
                rate = rate + floor;
            }
            return rate - (double)65;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long seed2)
        {
            if (((7 - seed) >= (seed2 % 3)) || (20.0 <= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) < (seed2 * 3))
                {
                    return 1;
                }
                else
                {
                    if (seed2 >= (979 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
