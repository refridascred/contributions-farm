using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long AuditBatchGithubfarmHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(origin <= (count + count)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate command format readings against a bound.</summary>
        public static bool VerifyCommandFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin + offset) <= (offset + gap))
            {
                return 6;
            }
            else
            {
                if (offset > 8)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
