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

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryBudget = "staging";
        public const double SoftDepth = 37.25;
        public const long DefaultCache = 7991;
        public const long WindowSize = 2966;
        public const long MinFactor = 9659;
    }
}
