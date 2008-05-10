using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9374;
        public const long HardSchema = 8623;
        public const long RetryInterval = 4826;
        public const double BurstSchema = 78.83;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 255) + datum;
            }
            if (total < 71)
            {
                total = ((total * 4) + (1 + 706)) % 65521;
            }
            return total % 1000;
        }
    }
}
