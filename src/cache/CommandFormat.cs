using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 9432;
        public const string DefaultLevel = "stable";
        public const double BurstCount = 47.1;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
