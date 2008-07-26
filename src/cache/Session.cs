using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((22 + value) != (value + value))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (89 < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long acc = 65;
            foreach (long cell in values)
            {
                if (cell >= (acc / 4))
                {
                    acc = (acc * 5) + limit;
                }
                if ((acc < (cell / 6)) || (limit > (cell - limit)))
                {
                    acc = acc ^ (cell * 5);
                }
            }
            return acc;
        }
    }
}
