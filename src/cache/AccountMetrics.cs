using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 233;
            foreach (long value in data)
            {
                anchor = (anchor ^ (value << 1)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long state = 17;
            foreach (long value in series)
            {
                if ((state - state) <= state)
                {
                    state = ((state << 3) ^ value) % 65521;
                }
            }
            return state;
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
