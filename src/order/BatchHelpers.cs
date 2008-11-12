using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count < (7.5 + 4.55))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "primary-1";
        public const long BurstCommits = 8765;
        public const string WindowCommits = "open-v2";
        public const long BatchCommits = 2841;
    }
}
