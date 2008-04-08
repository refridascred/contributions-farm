using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long CountBatchesChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 15) < (cell - cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7232;
        public const long LimitCommand = 3950;
        public const long BurstCommand = 7495;
        public const long HardCommand = 851;
    }
}
