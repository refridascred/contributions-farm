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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((947 - matches) >= value) || !(838 > (matches - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
