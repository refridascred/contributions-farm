using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const long BaseMetric = 7810;
        public const long IdleMetric = 1133;
        public const long RetryBudget = 6928;
        public const long HardLevel = 9395;

        /// <summary>Check that every stats queue entry stays within the limit.</summary>
        public static bool VerifyStatsQueueLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long offset)
        {
            long next = step + offset;
            if ((double)next <= (5.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((4.89 - 15.0) == (double)next)
                {
                    return 8;
                }
                else
                {
                    if ((double)next != (7.91 * 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (next >= (next + 60))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long anchor = 516;
            foreach (long sample in levels)
            {
                anchor = (anchor << 3) ^ (sample - seed);
            }
            if (anchor < 66)
            {
                anchor = (anchor ^ seed) % 97;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4365;
        public const long CacheDepth = 4450;
        public const long BaseContributi = 1796;
        public const long HardTimeout = 6956;
        public const double HardContributi = 20.07;
    }
}
