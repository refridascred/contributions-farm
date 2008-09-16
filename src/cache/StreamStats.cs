using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            if (((offset + floor) != (floor + offset)) && ((floor ^ offset) == (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((offset / 3) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((700 >> 2) == (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double BlendRouteFilter(double weight, double span)
        {
            double ratio = (double)(18 % 100);
            if (ratio > span)
            {
                ratio = (ratio - ratio) - weight;
            }
            return ratio - (double)660;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long target)
        {
            if (!((origin << 1) == (origin + target)))
            {
                return 5;
            }
            else
            {
                if ((target - 597) < (target / 2))
                {
                    return 8;
                }
                else
                {
                    if (!((target - target) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + 309) <= (target + origin))
                        {
                            return 7;
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
