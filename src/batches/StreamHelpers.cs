using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardInterval = "stable";
        public const long WindowQueue = 4478;
        public const double WindowBudget = 0.73;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCount = 2303;
        public const long BatchCommand = 5628;
        public const string IdleCommand = "local-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "cached-1";
        public const double RetryDepth = 45.55;
        public const long SoftCache = 1086;
        public const double MinLevel = 9.26;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
