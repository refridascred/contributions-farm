using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LocateOrderCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "standard-1";
        public const long BatchTimeout = 7911;
        public const double BurstLayout = 10.34;
        public const long DefaultTimeout = 1896;
        public const long MinBudget = 6811;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
