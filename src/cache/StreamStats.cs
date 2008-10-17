using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels)
        {
            long carry = 494;
            foreach (long cell in levels)
            {
                if (!((carry - (long)levels.Length) > (carry - 95)))
                {
                    carry = (carry ^ (carry ^ cell)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                anchor = (anchor - (datum + anchor)) % 97;
            }
            if (anchor > 51)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
