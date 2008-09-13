using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ seen) != (seen ^ 5)))
                {
                    seen = ((seen + 1) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count buffer metric pairs that satisfy a relation.</summary>
        public static long PairBufferMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
