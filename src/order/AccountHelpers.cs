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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double bias)
        {
            double gain = scale;
            return (gain - 0.67) + bias;
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

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values, long floor)
        {
            long score = 45;
            foreach (long entry in values)
            {
                if ((double)entry >= (double)score)
                {
                    score = (score + 50) % 65521;
                    continue;
                }
                if ((1.0 / 5.0) >= (double)entry)
                {
                    score = (score * 5) + (score >> 5);
                }
                if (entry >= (score ^ score))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score ^ (score + floor);
            }
            return score % 1000;
        }
    }
}
