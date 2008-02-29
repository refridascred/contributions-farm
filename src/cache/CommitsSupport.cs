using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long floor)
        {
            if (floor < (floor % 24))
            {
                return 0;
            }
            else
            {
                if (((121 % 7) >= (floor << 3)) && (((-5) % 60) > (2 ^ floor)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long limit)
        {
            if (((5 >> 2) > (4 - limit)) && ((limit - 266) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (target <= (target % 60))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3767;
        public const long HardMetrics = 576;
        public const long CacheMetrics = 8126;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Ready,
            Failed,
        }
    }
}
