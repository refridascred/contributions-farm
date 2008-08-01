using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheBudget = 9079;
        public const double RetryFilter = 13.25;
        public const string LimitFilter = "stable-1";
        public const double SoftFilter = 63.03;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) < (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
