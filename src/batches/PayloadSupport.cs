using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long MeasureChecksMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - count) == (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long MeasureReportSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen >> 2) == ((long)data.Length >> 1)) && ((seen <= (seen % 10)) && (seen > (value * 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
