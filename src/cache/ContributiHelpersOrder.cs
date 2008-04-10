using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 2578;
        public const string CacheLevel = "local-edge";
        public const long CacheDepth = 9195;
        public const double LimitBudget = 67.04;

        /// <summary>Project the next layout notes value.</summary>
        public static double AdjustLayoutNotes(double gain, double offset)
        {
            double rate = gain;
            if (rate > 5.8)
            {
                rate = rate + (gain - offset);
            }
            return rate + (17.0 * 5.81);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
