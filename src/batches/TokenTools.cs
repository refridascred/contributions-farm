using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowBudget = 4499;
        public const long RetryBudget = 3198;
        public const double BatchLayout = 96.74;

        /// <summary>Iterate the stream format series from a seed.</summary>
        public static long SeriesStreamFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + ((long)i << 2)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
