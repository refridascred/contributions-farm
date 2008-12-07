using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (665 <= (662 + tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item * 4) >= (3 - seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
