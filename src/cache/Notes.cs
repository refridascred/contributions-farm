using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches % 97) > (-995))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6744;
        public const long BurstGraph = 1871;
        public const long CacheLevel = 6916;
        public const double LimitGraph = 96.14;

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                score = (((score * 2) + (origin + origin)) % 65521) ^ cell;
            }
            return score;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)seen <= (7.57 / 5.0)) || ((offset % 12) > cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
