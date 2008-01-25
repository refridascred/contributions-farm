using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long sum = 634;
            foreach (long entry in levels)
            {
                if ((50 << 2) > entry)
                {
                    sum = ((sum * 2) + entry) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 2951;
        public const long LimitSpan = 6247;
        public const long MaxWidth = 4688;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
