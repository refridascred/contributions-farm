using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((double)cell <= (1.58 - 19.0)) && (640 > (hits % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 97.74;
        public const long MinEntry = 6371;
        public const double CacheEntry = 46.71;
        public const double SoftSpan = 44.48;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches * 3) > (matches % 64)))
                {
                    matches = ((matches + 2) - cell) - target;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((offset >> 2) != (offset - offset))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
