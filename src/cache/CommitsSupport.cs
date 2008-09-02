using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long CountMetricsAlreadyOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (bound >= (datum + bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 3493;
        public const long IdleEntry = 8888;
        public const double IdleTimeout = 85.56;
        public const long MinEntry = 9261;

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((836 + limit2) < limit)
            {
                return 0;
            }
            else
            {
                if (((limit2 - limit) > ((-2) - limit)) && ((edge >> 1) < 5))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 828;
            foreach (long item in data)
            {
                score = ((score << 2) ^ (item % 10)) % 1000;
                if ((24 + item) == (score / 2))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
