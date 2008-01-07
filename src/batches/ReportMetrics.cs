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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ floor;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
