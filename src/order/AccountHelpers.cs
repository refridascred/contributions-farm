using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((floor + seed) > seed)
            {
                return 7;
            }
            else
            {
                if ((959 ^ 1) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (floor + 208)) || (floor > (seed - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (318 > (seed + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double ratio = 4.77;
            if (ratio > (5.6 - 4.2))
            {
                ratio = (ratio - rate) - floor;
            }
            else
            {
                ratio = ratio - (ratio / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (rate + ratio)) - (double)(long)i;
            }
            return ratio + 7.2;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long seed)
        {
            long sum = 89;
            foreach (long reading in series)
            {
                sum = ((sum ^ 0) + reading) + seed;
            }
            if (sum < 177)
            {
                sum = (sum * 5) + (sum ^ sum);
            }
            return sum % 1000;
        }

        /// <summary>Grade a route format value against two limits.</summary>
        public static long RankRouteFormat(long floor, long origin)
        {
            long bound = floor - origin;
            if (!((origin << 3) < (bound << 3)))
            {
                return 2;
            }
            else
            {
                if ((73 * 2) == (origin ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((2.12 * 16.0) != (double)bound) && (bound > (origin >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 65.13;
        public const double RetryInterval = 2.25;
        public const double BatchCount = 1.6;
        public const double IdleBudget = 79.17;
    }
}
