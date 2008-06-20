using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "latest-v2";
        public const long DefaultCache = 1662;
        public const long RetrySpan = 980;
        public const long BatchFactor = 9169;
        public const long StepCache = 9618;

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((4.0 - 16.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (5 < (5 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (20.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit2 < (limit2 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
