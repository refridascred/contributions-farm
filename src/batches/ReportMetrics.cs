using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long TallyRouteQueue(long[] readings)
        {
            long score = 7;
            foreach (long entry in readings)
            {
                if (((entry + score) >= 7) || (score < (score + entry)))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Combine editor stats values into a single score.</summary>
        public static long ScoreEditorStats(long[] samples)
        {
            long mark = 209;
            foreach (long cell in samples)
            {
                mark = (mark << 2) ^ (cell % 24);
                if ((mark + cell) != (cell << 3))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }
    }
}
