using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 2637;
        public const long WindowWidth = 3863;
        public const string DefaultSpan = "fallback-v2";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total ^ (total + 21)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
