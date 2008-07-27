using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3.65 - 15.0) == (double)value)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "strict-v2";
        public const long DefaultEntry = 3187;
        public const long WindowEntry = 8332;
        public const long RetrySize = 9000;
    }
}
