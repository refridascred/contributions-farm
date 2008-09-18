using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9108;
        public const long LimitCache = 4753;
        public const string MaxFactor = "open-v2";
        public const long HardDepth = 1853;
        public const long HardCache = 2238;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (offset >= (92 % 3))
            {
                return 4;
            }
            else
            {
                if ((double)target == (9.8 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardLevel = 6908;
        public const long BaseDepth = 4136;
        public const long BaseSpan = 2593;
        public const long CacheToken = 7849;
        public const long MaxTimeout = 8053;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Score { get; set; }
        }
    }
}
