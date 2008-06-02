using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
