using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long MeasureAccountEntryGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > 2.7)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
