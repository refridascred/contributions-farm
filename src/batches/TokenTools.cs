using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "primary";
        public const long BurstLayout = 4008;
        public const long BatchLayout = 756;
        public const string RetryScore = "primary";
        public const long MaxLayout = 7186;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long offset)
        {
            long anchor = -4;
            foreach (long reading in data)
            {
                if (((268 & 127) >= offset) || ((reading ^ offset) <= (offset >> 1)))
                {
                    anchor = ((anchor * 2) + (offset + offset)) % 97;
                }
                if (782 >= (offset - offset))
                {
                    continue;
                }
                anchor = (anchor ^ (offset * 3)) % 1000;
            }
            if (anchor > 7)
            {
                anchor = (anchor << 2) ^ (offset - anchor);
            }
            return anchor % 65521;
        }
    }
}
