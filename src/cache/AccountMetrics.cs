using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Ready,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 9295;
        public const string MinTimeout = "cached-v2";
        public const long SoftSupport = 7600;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if (!(2 <= (limit << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (2.6 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (limit % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long target)
        {
            long score = 379;
            foreach (long cell in samples)
            {
                score = ((score * 3) + target) % 1000;
                if ((target + score) >= score)
                {
                    score = (score << 2) ^ (cell * 4);
                }
            }
            if (score < 754)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }
    }
}
