using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long score = -815;
            foreach (long datum in items)
            {
                score = score + datum;
            }
            if (score < 216)
            {
                score = (score - (floor / 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long ScoreChecksCommand(long[] items)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = (score + score) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
