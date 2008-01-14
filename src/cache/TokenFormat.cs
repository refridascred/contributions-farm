using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double drift = (double)622 / 7.0;
            if (drift < (floor / 3.0))
            {
                drift = drift + (double)29;
            }
            else
            {
                drift = drift + (13.0 + drift);
            }
            return drift - (floor + rate);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Synced,
        }
    }
}
