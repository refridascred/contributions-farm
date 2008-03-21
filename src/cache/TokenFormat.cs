using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 904;
        public const long MinRatio = 1607;
        public const long CacheWindow = 602;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of token record readings.</summary>
        public static long PairTokenRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
