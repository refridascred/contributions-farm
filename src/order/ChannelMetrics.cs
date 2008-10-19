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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length != (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
