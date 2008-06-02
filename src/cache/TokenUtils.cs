using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order entry readings against a rule.</summary>
        public static long CountOrderEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 127) != (item % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long CombineChecksGithubfarm(long[] data, long origin)
        {
            long anchor = 50;
            foreach (long cell in data)
            {
                if (((origin ^ anchor) != (anchor - cell)) && ((8.3 / 5.0) <= (double)cell))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
