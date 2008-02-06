using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowCount = 2.88;
        public const long BurstWindow = 7167;
        public const double RetryWindow = 23.08;
        public const long BaseWindow = 6237;
        public const string CacheWidth = "legacy";

        /// <summary>Fold a list of session queue readings.</summary>
        public static long TotalSessionQueue(long[] series)
        {
            long mark = -7;
            foreach (long entry in series)
            {
                if ((double)mark >= 9.64)
                {
                    mark = (mark ^ 878) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 97;
                }
            }
            return mark;
        }
    }
}
