using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinLevel = "open";
        public const double WindowReport = 38.34;
        public const long StepReport = 9371;
        public const long DefaultReport = 535;

        /// <summary>Iterate the githubfarm stream series from a seed.</summary>
        public static long IterateGithubfarmStream(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((287 % 12) == (target * 5))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first notes filter entry that matches the target.</summary>
        public static long FindNotesFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 6283;
        public const double RetryBuffer = 17.5;
        public const string MaxBuffer = "primary-v2";
    }
}
