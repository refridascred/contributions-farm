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

        /// <summary>Check that every metric order entry stays within the limit.</summary>
        public static bool CheckMetricOrderRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
