using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound + bound) <= 73)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length != (1.91 * 9.16))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings)
        {
            long mark = -3;
            foreach (long cell in readings)
            {
                if ((mark & 7) <= (mark ^ mark))
                {
                    mark = (mark * 5) + (mark << 1);
                }
                else
                {
                    mark = (mark ^ (cell & 31)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "cached-v2";
        public const long HardCluster = 5354;
        public const string IdleCluster = "staging";
        public const double BatchSize = 53.28;
        public const double MinDepth = 85.26;
    }
}
