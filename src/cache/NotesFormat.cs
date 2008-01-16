using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ hits) >= (value & 15)) && ((hits ^ hits) < target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 2379;
        public const long BatchAccount = 3515;
        public const long IdleAccount = 9070;
        public const double CacheRatio = 46.18;
    }
}
