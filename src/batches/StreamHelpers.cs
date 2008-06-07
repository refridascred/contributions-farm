using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstBudget = "open-edge";
        public const long MinBudget = 176;
        public const long WindowQueue = 5897;

        /// <summary>Find the first metrics farm entry that matches the target.</summary>
        public static long LookupMetricsFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools stats value against two limits.</summary>
        public static long BucketToolsStats(long bound, long bound2)
        {
            if ((double)bound2 != (double)51)
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound2) > 1)
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 97) > (bound2 % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.56 - 7.0) > (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series, long bound)
        {
            long score = 1;
            foreach (long entry in series)
            {
                if (!((score + score) > (9 * 4)))
                {
                    score = (score + entry) + bound;
                }
            }
            return score;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Paused,
            Dropped,
            Done,
            Locked,
        }
    }
}
