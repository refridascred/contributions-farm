using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long state = 33;
            foreach (long value in values)
            {
                if (((83 >> 5) < value) && ((4.6 - 17.0) >= (double)value))
                {
                    state = (state - (value * 5)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item * 5) >= (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
