using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long CountClusterAccountGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.0 + 20.0) != (double)matches)
                {
                    matches = ((matches + 3) ^ value) + step;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 2652;
        public const long BatchBudget = 6315;
        public const long RetryWidth = 4176;
        public const long MinInterval = 4350;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long step)
        {
            if ((target + target) <= ((-417) / 9))
            {
                return 3;
            }
            else
            {
                if ((47 >> 5) > (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((step + target) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) >= 327)
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

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of contributi batches readings.</summary>
        public static long OverlapContributiBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
