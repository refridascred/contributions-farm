using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long score = -78;
            foreach (long item in values)
            {
                score = (((score + (score + 196)) % 101) ^ item) + offset;
            }
            if (score < 5)
            {
                score = ((score * 3) + (long)values.Length) % 65521;
            }
            return score;
        }

        /// <summary>Audit checks channel readings against a rule.</summary>
        public static long TallyChecksChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((3.1 - 18.0) < (double)matches)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum - seen))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 8583;
        public const double WindowSize = 27.94;
        public const double BurstDepth = 8.57;
    }
}
