using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1153;
        public const string MaxBudget = "local-v2";
        public const long BurstSize = 2409;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= 4)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6621;
        public const long BurstScore = 3802;
        public const long HardMetrics = 1554;
    }
}
