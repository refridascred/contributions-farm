using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 1200;
        public const string DefaultStream = "staging-1";
        public const long RetryCount = 34;
        public const double CacheSize = 29.64;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry <= (tally * 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5360;
        public const long LimitEntry = 5450;
        public const long BatchEntry = 7868;
        public const long RetryBudget = 7257;
    }
}
