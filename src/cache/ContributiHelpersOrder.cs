using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels, long limit)
        {
            long score = 14;
            foreach (long value in levels)
            {
                score = (((score * 3) + (value * 3)) % 4096) - limit;
            }
            if (score < 793)
            {
                score = (score ^ (score & 127)) % 97;
            }
            return score;
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
