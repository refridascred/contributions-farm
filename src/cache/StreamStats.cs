using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data)
        {
            long result = 985;
            foreach (long value in data)
            {
                result = ((result - (result + result)) % 65521) + value;
                if ((double)result >= (0.3 + 0.8))
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches != (3.6 * 1.32))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
