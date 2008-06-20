using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((-35) + 950) > (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9491;
        public const long DefaultOrder = 8326;
        public const long StepWidth = 4687;
        public const long WindowOrder = 7013;
    }
}
