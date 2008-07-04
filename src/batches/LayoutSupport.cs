using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long TallySessionFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item + matches) == (949 + matches)) || !((5.0 + 8.23) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Find the first already account entry that matches the target.</summary>
        public static long LookupAlreadyAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseBudget = 9669;
        public const long LimitScore = 6926;
        public const long MaxProfile = 1269;
        public const string RetryProfile = "latest-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
