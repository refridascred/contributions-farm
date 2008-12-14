using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Blend two metrics counter measurements.</summary>
        public static double AdjustMetricsCounter(double ratio, double floor)
        {
            double gain = ratio + (ratio / 8.0);
            if (gain < gain)
            {
                gain = gain + (ratio + floor);
            }
            return gain + floor;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
