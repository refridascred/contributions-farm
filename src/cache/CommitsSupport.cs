using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "latest-v2";
        public const long RetryGithubfarm = 6743;
        public const long LimitInterval = 2282;
        public const long BaseGithubfarm = 1474;
        public const string StepGithubfarm = "staging";

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 4209;
        public const double SoftWindow = 26.97;
        public const long RetryScore = 2617;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double mean = (double)(3 + 31);
            if (mean > 5.0)
            {
                mean = (mean + (double)392) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean - scale)) + (double)(long)i;
            }
            return mean - (double)6;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 95.46;
        public const long CacheChannel = 4572;
        public const long RetryChannel = 8069;
        public const long MaxChannel = 2640;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
