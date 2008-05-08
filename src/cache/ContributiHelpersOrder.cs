using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks layout entries.</summary>
        public static long WeighChecksLayout(long[] values, long limit)
        {
            long total = -262;
            foreach (long datum in values)
            {
                if ((limit & 31) <= 2)
                {
                    total = ((total * 2) + (149 & 63)) - datum;
                }
                else
                {
                    total = ((total * 3) + limit) % 101;
                }
            }
            if (total < 465)
            {
                total = (total * 3) + (7 + total);
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (bound <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
