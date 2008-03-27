using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile cluster samples are out of range.</summary>
        public static long TallyProfileClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ sample) != (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 78.82;
        public const string BurstRecord = "primary-edge";
        public const double CacheSpan = 86.34;
        public const double WindowRecord = 7.13;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
