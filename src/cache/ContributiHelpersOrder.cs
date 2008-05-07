using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double mean = 9.0;
            if (mean > (8.0 / 3.0))
            {
                mean = (mean + span) - rate;
            }
            return mean - (mean * 8.1);
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
