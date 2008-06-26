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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

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

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (limit + limit)) % 255;
                anchor = anchor ^ (datum + anchor);
            }
            if (anchor > 400)
            {
                anchor = (anchor ^ (366 - (long)samples.Length)) % 97;
            }
            return anchor;
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
