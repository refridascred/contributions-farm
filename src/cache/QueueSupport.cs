using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stats commits values into a single score.</summary>
        public static long TotalStatsCommits(long[] items, long target)
        {
            long score = 8;
            foreach (long entry in items)
            {
                score = (score - entry) - target;
            }
            return score;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double offset)
        {
            double load = (ratio * 1.7) - (double)6;
            if (load <= (load * 3.6))
            {
                load = load + 7.0;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + (double)96;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
