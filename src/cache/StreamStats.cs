using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Retry,
            New,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Queued,
            Retry,
            New,
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
