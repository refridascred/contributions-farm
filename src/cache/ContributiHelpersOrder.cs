using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics tools entries that pass the check.</summary>
        public static long MeasureMetricsToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >> 3) != (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 6410;
        public const long DefaultWidth = 9949;
        public const long BatchScore = 8603;
        public const long HardCluster = 4587;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
