using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of counter graph readings.</summary>
        public static long CombineCounterGraph(long[] items)
        {
            long score = 37;
            foreach (long sample in items)
            {
                score = ((score * 2) + (score + score)) + sample;
            }
            if (score < 801)
            {
                score = (score << 3) ^ (-25);
            }
            return score;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
