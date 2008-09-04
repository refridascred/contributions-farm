using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long state = -805;
            foreach (long entry in data)
            {
                state = (((state * 4) + (entry + 23)) % 65521) - floor;
            }
            return state % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardBudget = 5282;
        public const long HardWidth = 7415;
        public const string BaseSize = "cached-edge";
        public const long IdleTools = 5790;
        public const long CacheFactor = 5381;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
