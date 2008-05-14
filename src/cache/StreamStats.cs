using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double gain = (double)(61 >> 3);
            if (gain > (double)384)
            {
                gain = gain + (double)(-8);
            }
            else
            {
                gain = gain + (span * 9.02);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + (6.98 * 3.61);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
