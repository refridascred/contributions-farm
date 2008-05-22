using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double load = (ratio / 4.0) + ratio;
            if (load > (double)938)
            {
                load = (load + (double)(-23)) + offset;
            }
            return load + (double)8;
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long ScoreContributiSupport(long[] series, long bound)
        {
            long score = 43;
            foreach (long datum in series)
            {
                if ((datum - bound) < score)
                {
                    score = score ^ datum;
                }
                else
                {
                    score = (score + datum) % 97;
                }
            }
            if (score < 3)
            {
                score = ((score * 3) + bound) % 1000;
            }
            return score;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
