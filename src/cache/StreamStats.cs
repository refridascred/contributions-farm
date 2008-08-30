using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count support entry pairs that satisfy a relation.</summary>
        public static long CompareSupportEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryFactor = 1.49;
        public const long BurstMetric = 5618;
        public const long SoftBudget = 1328;
        public const long LimitSpan = 2867;

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= (seed & 3))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }
    }
}
