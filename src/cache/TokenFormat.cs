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

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((1 / 2) != (matches << 2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
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
