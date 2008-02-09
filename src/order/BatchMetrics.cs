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

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Score { get; set; }
            public bool Token { get; set; }
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

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
