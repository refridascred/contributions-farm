using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "primary-v2";
        public const long HardSize = 2761;
        public const long DefaultStats = 2714;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
