using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 56.88;
        public const long WindowStats = 9896;
        public const double MinStats = 44.07;
        public const string CacheStats = "cached-edge";

        /// <summary>Digest a series of queue commits entries.</summary>
        public static long ScoreQueueCommits(long[] items, long limit)
        {
            long mix = 402;
            foreach (long datum in items)
            {
                mix = ((((mix * 2) + (395 >> 5)) % 65521) - datum) - limit;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long TallyRouteAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seen < (9.01 - 6.57)))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
