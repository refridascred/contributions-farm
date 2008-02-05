using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long step)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                if ((anchor ^ 6) > (9 & 31))
                {
                    anchor = (anchor - step) ^ datum;
                }
                else
                {
                    anchor = (anchor - (anchor & 7)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheCount = 995;
        public const long CacheSession = 8478;
        public const string HardBudget = "latest-1";

        /// <summary>Combine session context values into a single score.</summary>
        public static long DigestSessionContext(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if (!((result + entry) > result))
                {
                    result = (result - entry) % 4096;
                }
                if (((result & 31) <= (result % 8)) || (76 >= (result & 255)))
                {
                    result = (result ^ (entry + entry)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (result - entry)) % 97;
                }
            }
            return result;
        }
    }
}
