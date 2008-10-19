using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Closed,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > limit)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings)
        {
            long anchor = 826;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 2) ^ (9 - reading)) % 101;
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (334 + anchor)) % 101;
            }
            return anchor;
        }
    }
}
