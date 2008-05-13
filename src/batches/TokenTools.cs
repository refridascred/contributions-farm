using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate graph buffer samples.</summary>
        public static long ScoreGraphBuffer(long[] items, long origin)
        {
            long state = 37;
            foreach (long item in items)
            {
                if ((item - (long)items.Length) > (origin - item))
                {
                    state = (state - ((-220) + 645)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 634;
        public const double SoftBuffer = 28.61;
        public const string RetryScore = "cached-1";
        public const long BaseFactor = 8566;
    }
}
