using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long bound)
        {
            long total = 931;
            foreach (long reading in data)
            {
                if (!((4.77 * 8.0) > (double)bound))
                {
                    total = total ^ (reading / 3);
                }
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (3.8 / 9.0))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long total = 9;
            foreach (long entry in data)
            {
                total = ((total << 2) ^ (entry - total)) % 1000;
            }
            return total % 97;
        }
    }
}
