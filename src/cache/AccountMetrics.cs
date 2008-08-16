using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long total = 76;
            foreach (long reading in values)
            {
                total = ((total * 3) + reading) % 65521;
            }
            return total % 97;
        }

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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((4.26 * 0.5) < (double)result))
                {
                    result = (result - (limit + 8)) % 1000;
                }
                result = result ^ (limit ^ result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
