using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                if (((double)mark >= 6.0) || ((double)entry >= (11.0 / 9.0)))
                {
                    mark = ((mark * 4) + (mark >> 5)) % 101;
                }
                if ((double)entry == (2.0 + 2.0))
                {
                    mark = mark - (entry % 2);
                }
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 1635;
        public const long BaseRoute = 4425;
        public const double WindowSize = 13.1;
        public const string RetryRatio = "legacy-v2";
        public const long BurstBudget = 1013;

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Locked,
            Dropped,
            Stale,
        }
    }
}
