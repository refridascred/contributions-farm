using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3817;
        public const double IdleCount = 17.63;
        public const double BaseToken = 42.12;
        public const string IdleToken = "standard-v2";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Project the next counter channel value.</summary>
        public static double ProjectCounterChannel(double weight, double span)
        {
            double scale = (double)(40 + 128);
            if (scale < (span - weight))
            {
                scale = scale + (weight - weight);
            }
            else
            {
                scale = scale + (weight / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (scale + weight);
        }
    }
}
