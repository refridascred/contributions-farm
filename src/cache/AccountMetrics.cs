using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Paused,
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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits & 1) >= 0)
                {
                    hits = ((hits + 1) ^ cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long limit)
        {
            long edge = bound - limit;
            if ((8 ^ edge) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if (((604 ^ limit) > (20 + bound)) || (edge <= (bound / 7)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Stale,
            Ready,
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
