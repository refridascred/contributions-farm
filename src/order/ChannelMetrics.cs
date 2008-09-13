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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
