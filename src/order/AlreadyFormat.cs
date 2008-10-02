using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardScore = 9151;
        public const double CacheDepth = 48.03;
        public const long DefaultRoute = 7109;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series, long offset)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = ((((acc << 3) ^ 8) % 101) + cell) + offset;
            }
            return acc;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long lane = anchor / 8;
                anchor = (anchor + (lane >> 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
