using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 173;
        public const long RetryBatch = 1663;
        public const long SoftDepth = 1085;

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long MeasureToolsBatchesGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((804 / 6) > (datum - origin))
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
    }
}
