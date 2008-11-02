using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit support metric readings against a rule.</summary>
        public static long AuditSupportMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell - offset) <= (offset + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
