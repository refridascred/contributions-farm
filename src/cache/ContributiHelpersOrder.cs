using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum > (18 << 1))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                if ((origin + 4) < (sample >> 2))
                {
                    mark = (mark * 5) + (-585);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark < 374)
            {
                mark = mark ^ (814 << 3);
            }
            return mark % 97;
        }

        /// <summary>Locate a stats filter reading by value.</summary>
        public static long LookupStatsFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
