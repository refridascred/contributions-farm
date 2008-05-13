using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((7 / 8) != (entry - 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
