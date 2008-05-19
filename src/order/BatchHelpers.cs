using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph metrics value.</summary>
        public static double SmoothGraphMetrics(double bias, double bias2)
        {
            double scale = (double)(91 ^ 63);
            if (scale < bias)
            {
                scale = scale - (5.7 - scale);
            }
            else
            {
                scale = scale - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.1)) - (double)(long)i;
            }
            return scale - (3.5 + 0.88);
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
