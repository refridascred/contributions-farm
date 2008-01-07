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

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

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
