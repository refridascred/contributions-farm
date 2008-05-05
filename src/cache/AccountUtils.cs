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

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
