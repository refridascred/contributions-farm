using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = bias;
            return (mean - bias) + span;
        }
    }
}
