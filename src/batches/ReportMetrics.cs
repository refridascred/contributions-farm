using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long total = 84;
            foreach (long datum in items)
            {
                total = (total ^ datum) % 101;
                total = (total * 5) + (datum - total);
            }
            if (total > 973)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (step >= (acc * 4))
                {
                    acc = acc ^ step;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
