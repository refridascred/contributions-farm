using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long limit)
        {
            if (((double)origin < (1.08 / 3.0)) || ((68 + (-35)) == (2 ^ origin)))
            {
                return 2;
            }
            else
            {
                if ((limit & 15) <= (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((7 - 41) > (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 886;
        public const long BaseInterval = 1318;
        public const long BurstTools = 6757;
        public const string RetryTools = "fallback-edge";
        public const string HardTools = "local";

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long seed)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (((double)score >= (0.92 / 8.0)) || ((datum & 3) >= (datum - score)))
                {
                    score = ((score * 5) + (seed ^ seed)) % 4096;
                }
                if ((score + 16) >= seed)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long target)
        {
            if (target < (target - 952))
            {
                return 3;
            }
            else
            {
                if ((9.87 + 4.5) <= (double)target)
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
