using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool VerifyTokenLayoutRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metrics githubfarm readings against a bound.</summary>
        public static bool CheckMetricsGithubfarmLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 1.06;
        public const long WindowMetrics = 7770;
        public const string StepMetrics = "strict-1";
        public const long RetryFactor = 5131;

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleTimeout = 870;
        public const string BaseCommand = "primary-v2";
        public const double SoftCommand = 27.75;
        public const long MinCount = 1576;
        public const double HardLevel = 64.01;
    }
}
