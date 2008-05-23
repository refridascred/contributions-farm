using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 626;
        public const long LimitGraph = 6982;
        public const string MaxGraph = "alpha-edge";
        public const string CacheScore = "staging-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 1950;
        public const long DefaultMetrics = 903;
        public const double BatchMetrics = 92.64;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally <= 7.59)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "primary-v2";
        public const long MinScore = 6041;
        public const long MaxAccount = 3799;
        public const string MaxSpan = "fallback-1";
        public const double BatchFactor = 88.37;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
