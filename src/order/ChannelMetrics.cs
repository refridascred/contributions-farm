using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache record readings against a bound.</summary>
        public static bool VerifyCacheRecordRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value ^ floor) <= (value + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
