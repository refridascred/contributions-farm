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

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
