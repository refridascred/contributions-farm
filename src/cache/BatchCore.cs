using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit context stream readings against a rule.</summary>
        public static long MeasureContextStreamGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum >= (9.0 * 5.8)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long result = 137;
            foreach (long sample in data)
            {
                if ((7.0 / 7.0) <= (double)sample)
                {
                    result = ((result - (813 % 24)) % 1000) - floor;
                }
                else
                {
                    result = ((result << 2) ^ (sample ^ result)) % 255;
                }
                if ((double)result > (5.0 - 5.7))
                {
                    result = (result * 4) + (result / 4);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
