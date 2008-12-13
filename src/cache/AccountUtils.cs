using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double floor)
        {
            double mean = (double)0 * 1.72;
            return (mean + (floor / 7.0)) + rate;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Synced,
            Idle,
            Closed,
            New,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
