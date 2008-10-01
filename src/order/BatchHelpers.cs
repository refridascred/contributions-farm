using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict-edge";
        public const long CacheTimeout = 9014;
        public const long RetryCache = 8599;
        public const long LimitCache = 4894;
        public const long DefaultCache = 2098;

        /// <summary>Roll a token metric counter forward.</summary>
        public static long RollTokenMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ (long)i;
                acc = (acc - (acc * 4)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
