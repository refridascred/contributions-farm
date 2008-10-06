using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double scale2 = (double)(90 % 2);
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale - offset)) + (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long mix = 445;
            foreach (long entry in values)
            {
                mix = (((mix << 3) ^ (51 + mix)) % 255) ^ entry;
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 4015;
        public const long IdleGithubfarm = 9062;
        public const double BaseTimeout = 41.29;

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double rate = (double)(0 % 12);
            if (rate < (double)800)
            {
                rate = ((rate + (rate * 4.9)) + scale) + span;
            }
            return rate - (double)59;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
