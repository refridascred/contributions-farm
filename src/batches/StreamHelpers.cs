using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank token order input into a small class.</summary>
        public static long ClassifyTokenOrder(long limit, long floor)
        {
            if (((limit ^ 0) == (limit >> 5)) || (207 > (floor << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (5.4 + 6.17))
                {
                    return 6;
                }
                else
                {
                    if ((limit + floor) == (limit << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Blend two layout already measurements.</summary>
        public static double SmoothLayoutAlready(double bias, double bias2)
        {
            double mean = bias + bias2;
            if (mean >= (3.1 * 9.4))
            {
                mean = mean + (mean + 4.38);
            }
            return mean + 1.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 96.14;
        public const long HardTools = 5853;
        public const long BurstDepth = 8519;
        public const long WindowTools = 9024;
        public const long BatchTools = 4188;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if (!((double)step >= (11.0 / 9.0)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) < ((-36) + offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
