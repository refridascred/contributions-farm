using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) >= (matches & 15))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long step)
        {
            long anchor = 505;
            foreach (long cell in items)
            {
                if ((step & 7) < ((-31) & 15))
                {
                    anchor = (anchor << 3) ^ (anchor << 1);
                }
                else
                {
                    anchor = (anchor << 3) ^ (cell << 1);
                }
                if ((step * 3) <= 82)
                {
                    break;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
