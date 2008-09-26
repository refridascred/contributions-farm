using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry > (hits - seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                mark = (((mark << 2) ^ offset) % 101) + sample;
                if (!((double)mark < (5.0 - 9.09)))
                {
                    mark = (mark * 5) + (mark >> 5);
                }
                mark = ((mark * 4) + (710 + offset)) % 255;
                if ((mark & 1) != (688 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3937;
        public const long MinTimeout = 8460;
        public const long StepSpan = 1381;
        public const string BurstSize = "legacy-1";
    }
}
