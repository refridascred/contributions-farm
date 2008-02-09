using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSpan = "fallback-v2";
        public const long WindowFactor = 5888;
        public const long RetrySupport = 3254;

        /// <summary>Check that every profile schema entry stays within the limit.</summary>
        public static bool CheckProfileSchemaBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of checks context entries.</summary>
        public static long TotalChecksContext(long[] series)
        {
            long sum = 63;
            foreach (long cell in series)
            {
                if ((double)sum != (17.0 * 0.9))
                {
                    sum = (sum << 3) ^ cell;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3074;
        public const string MinTimeout = "alpha-v2";
        public const long LimitWidth = 430;
        public const string MaxSpan = "stable-edge";
        public const long CacheOrder = 341;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Locked,
            Queued,
            New,
            Done,
        }
    }
}
