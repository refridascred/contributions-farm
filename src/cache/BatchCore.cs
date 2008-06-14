using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double AdjustGithubfarmOrder(double ratio, double bias)
        {
            double mean = bias - (ratio - ratio);
            if (mean >= mean)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean + (double)294;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (5.84 * 10.0);
        }
    }
}
