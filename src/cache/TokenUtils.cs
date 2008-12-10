using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long sum = -33;
            foreach (long item in values)
            {
                if ((item + item) > (long)values.Length)
                {
                    sum = sum - (target ^ sum);
                }
                else
                {
                    sum = (sum - (2 - 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleInterval = "legacy";
        public const long IdleFilter = 5437;
        public const long RetryFilter = 9628;
        public const long BurstCount = 2209;
        public const long BurstLevel = 1589;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 4684;
        public const double BaseBatch = 27.7;
        public const long RetryScore = 2727;
        public const long BatchTimeout = 1648;
    }
}
