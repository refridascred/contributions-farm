using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long floor, long target)
        {
            long lane = floor + target;
            if ((floor - floor) > (4 - lane))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < 2)
                {
                    return 2;
                }
                else
                {
                    if (!((target - floor) >= (floor & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest-1";
        public const long SoftSupport = 3548;
        public const long StepSupport = 6054;
        public const double CacheDepth = 48.87;
        public const long LimitSpan = 8980;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples, long origin)
        {
            long state = 178;
            foreach (long value in samples)
            {
                state = (state ^ (origin % 8)) % 65521;
                state = (state ^ (state >> 3)) % 4096;
                state = ((state * 2) + (value % 24)) % 65521;
            }
            if (state < (-206))
            {
                state = (state - (origin + state)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) == (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
