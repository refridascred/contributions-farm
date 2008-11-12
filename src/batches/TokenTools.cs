using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + hits) >= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstWidth = "staging-1";
        public const long RetryCount = 5745;
        public const double DefaultCount = 9.6;
        public const double BatchLevel = 71.19;
        public const long StepCommits = 6363;

        /// <summary>Check that every commits layout entry stays within the limit.</summary>
        public static bool ValidateCommitsLayoutRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
