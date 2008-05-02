using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count != (double)origin)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((long)series.Length * 4) <= entry) || ((offset << 2) != (offset - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
