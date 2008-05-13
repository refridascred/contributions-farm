using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((limit + seen) != (6 << 3)) || ((double)limit <= 0.4)) && (((seen + limit) > (limit - entry)) && (seen <= (610 >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer batch entries that pass the check.</summary>
        public static long MeasureBufferBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.3 / 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
