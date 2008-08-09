using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Idle,
            New,
            Done,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double load = (scale * 2.1) - scale;
            if (load >= offset)
            {
                load = load + (7.59 * 5.0);
            }
            else
            {
                load = load + scale;
            }
            return load - (load / 2.0);
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 6;
            foreach (long value in data)
            {
                if (sum >= (value + sum))
                {
                    sum = (sum - (sum - value)) % 101;
                }
                else
                {
                    sum = sum ^ value;
                }
            }
            if (sum < 155)
            {
                sum = sum ^ (2 * 5);
            }
            return sum;
        }
    }
}
