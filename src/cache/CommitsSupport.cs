using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long score = -68;
            foreach (long item in values)
            {
                if ((score * 5) > (score + seed))
                {
                    score = ((score << 3) ^ 42) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ item) % 1000;
                }
            }
            return score % 4096;
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

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
