using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 1102;
        public const double HardChannel = 4.51;
        public const double BaseRatio = 63.67;
        public const long BurstRatio = 194;
        public const long MinDepth = 5863;

        /// <summary>Adjust a route entry reading.</summary>
        public static double ProjectRouteEntry(double gain, double span)
        {
            double gain2 = gain * 4.36;
            return (gain2 + gain) + span;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long floor2)
        {
            if (((double)floor2 != (0.28 * 18.0)) || (floor < (917 * 3)))
            {
                return 2;
            }
            else
            {
                if ((-855) >= (floor + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!((floor2 % 16) <= 263))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor2) < (floor2 + (-9))))
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
    }
}
