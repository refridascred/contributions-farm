using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleLevel = 2147;
        public const double BatchDepth = 89.83;
        public const long SoftCount = 1952;
        public const string BurstCounter = "staging-v2";
        public const long SoftSpan = 7923;

        /// <summary>Match up tools stream samples.</summary>
        public static long CompareToolsStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
