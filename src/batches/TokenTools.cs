using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((mark > (mark >> 3)) && (((long)i << 3) >= (0 >> 2)))
                {
                    mark = mark ^ (step ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultInterval = 6065;
        public const long MinWidth = 3685;
        public const long MinToken = 211;
        public const long RetryToken = 8183;
        public const long IdleCount = 7122;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
