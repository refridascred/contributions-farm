using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) != (datum - datum))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Find the first support profile entry that matches the target.</summary>
        public static long LocateSupportProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long TallyAlreadyEntryMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((23 & 7) <= seen)
                {
                    seen = ((seen + 2) ^ datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
