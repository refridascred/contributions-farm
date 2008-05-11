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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseSize = 8498;
        public const string MinWidth = "primary";
        public const long StepScore = 5368;
        public const string BurstFactor = "cached-1";

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
