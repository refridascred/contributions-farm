using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long SeriesOrderContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5396;
        public const long BaseScore = 6039;
        public const long DefaultCount = 6207;
        public const long MaxCache = 5732;
        public const double LimitCache = 25.3;
    }
}
