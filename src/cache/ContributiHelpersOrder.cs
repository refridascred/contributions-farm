using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series, long step)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                if (1.82 <= (double)step)
                {
                    mark = ((mark * 5) + (517 + mark)) ^ datum;
                }
            }
            if (mark < 671)
            {
                mark = ((mark * 2) + step) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)offset < (3.71 - 7.6))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
