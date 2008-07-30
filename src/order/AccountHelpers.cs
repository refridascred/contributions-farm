using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 93.82;
        public const string StepProfile = "cached-v2";
        public const long WindowProfile = 9452;
        public const long DefaultProfile = 8108;
        public const double LimitLevel = 61.14;
    }
}
