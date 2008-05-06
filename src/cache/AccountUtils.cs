using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchRatio = "staging";
        public const long BurstTools = 113;
        public const long BaseTools = 9488;
        public const string RetryDepth = "latest-1";
        public const long BatchTools = 5408;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
