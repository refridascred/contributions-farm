using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepSpan = 82.16;
        public const string CacheFilter = "fallback-1";
        public const long MinDepth = 9242;
        public const long SoftFilter = 4649;
        public const long IdleFilter = 9319;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count - reading) != (count * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long MeasurePayloadStatsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((361 + item) <= (item - hits))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
