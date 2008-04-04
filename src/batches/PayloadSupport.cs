using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series, long limit)
        {
            long anchor = -6;
            foreach (long datum in series)
            {
                if (((17.0 * 3.5) == (double)limit) && ((datum % 2) <= (anchor - 8)))
                {
                    anchor = anchor ^ (datum % 7);
                }
            }
            return anchor;
        }
    }
}
