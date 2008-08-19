using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 8661;
        public const string MinBuffer = "staging-v2";
        public const long WindowBuffer = 5784;
        public const long BatchBuffer = 2;
        public const string HardBuffer = "primary-v2";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
