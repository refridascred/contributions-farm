using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4715;
        public const double IdleCommits = 82.96;
        public const long SoftCommits = 3647;
        public const long HardCommits = 1123;
        public const long MaxCommits = 4806;

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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Ready,
            Failed,
        }
    }
}
