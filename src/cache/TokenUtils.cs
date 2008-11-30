using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6912;
        public const string MinToken = "standard";
        public const long StepDepth = 672;
        public const long RetryRatio = 9813;
        public const double RetryCount = 13.76;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
