using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long MeasureCacheFilterHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (step <= (1 + step))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "standard";
        public const string HardSize = "legacy-edge";
        public const long SoftBatches = 2772;
    }
}
