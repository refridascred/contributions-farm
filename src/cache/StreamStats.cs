using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6588;
        public const double MinTimeout = 27.54;
        public const double BurstReport = 38.04;

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
