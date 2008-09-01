using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((step - step) <= 74) && ((11 - (-2)) <= item)) || ((step * 5) == (item * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) == (count - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
