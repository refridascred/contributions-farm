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

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5376;
        public const double MaxPayload = 22.93;
        public const long DefaultSpan = 8362;
        public const double SoftPayload = 80.01;
        public const long BaseTimeout = 1131;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
