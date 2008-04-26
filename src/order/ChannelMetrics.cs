using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cluster stream readings against a rule.</summary>
        public static long MeasureClusterStreamMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((1 - hits) > (757 << 2))
                {
                    hits = ((hits + 3) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 651;
        public const string MinFactor = "open-1";
        public const double SoftSpan = 53.34;

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long SeekCommitsFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
