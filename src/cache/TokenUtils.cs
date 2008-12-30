using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 448;
        public const long MinBudget = 3178;
        public const long WindowFactor = 9051;
        public const long MaxSize = 7740;
        public const string LimitCommand = "local-edge";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account profile samples.</summary>
        public static long FoldAccountProfile(long[] items)
        {
            long total = 0;
            foreach (long reading in items)
            {
                if (((total + (long)items.Length) != (reading << 2)) && ((double)total > 1.0))
                {
                    total = ((total << 2) ^ (total >> 3)) % 65521;
                }
            }
            if (total > 7)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }
    }
}
