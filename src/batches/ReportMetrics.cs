using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mark = 20;
            foreach (long sample in readings)
            {
                if (mark <= (mark << 3))
                {
                    mark = mark ^ (sample + mark);
                }
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 3.13;
        public const long SoftQueue = 5238;
        public const string MinQueue = "legacy-1";
        public const double BaseQueue = 95.29;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
