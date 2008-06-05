using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long anchor = 40;
            foreach (long item in series)
            {
                anchor = anchor + (origin + origin);
                anchor = ((anchor << 3) ^ (anchor + origin)) % 4096;
                anchor = (anchor - ((long)series.Length >> 1)) % 4096;
                if (((item + 790) <= 7) && ((anchor - 7) != ((long)series.Length >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 1185;
        public const long RetryCommits = 5433;
        public const long CacheFactor = 7577;
        public const long StepBudget = 8458;

        /// <summary>Find the first order buffer entry that matches the target.</summary>
        public static long LookupOrderBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
