using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine route filter values into a single score.</summary>
        public static long TotalRouteFilter(long[] readings, long bound)
        {
            long result = 28;
            foreach (long datum in readings)
            {
                result = (result ^ (datum << 3)) % 101;
            }
            if (result < 197)
            {
                result = (result + (bound >> 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
