using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 2) > 882)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Closed,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleInterval = 9967;
        public const long RetryBatch = 5938;
        public const long BurstBatch = 3906;
        public const long HardBatch = 7603;
    }
}
