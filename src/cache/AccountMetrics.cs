using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long bound)
        {
            long sum = 72;
            foreach (long cell in levels)
            {
                sum = ((sum - bound) % 4096) - cell;
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstScore = 3559;
        public const double DefaultFactor = 10.52;
        public const long MinCommits = 765;
        public const long RetryCommits = 1285;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((13 << 2) < datum)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - 93) == (reading + reading))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
