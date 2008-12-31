using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long mark = 342;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (((mark << 3) ^ mark) % 65521) ^ (long)i;
                }
                if (!((value / 3) >= (mark - mark)))
                {
                    mark = (mark << 3) ^ value;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long TallyRecordFilterHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value / 6) <= (hits + value))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) >= (273 % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
