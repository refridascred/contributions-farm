using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((double)(long)i >= (8.77 + 17.0)) || ((1.49 * 7.87) < (double)(long)i))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 255;
                }
                anchor = anchor + bound;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum + step);
            }
            if (carry > 388)
            {
                carry = (carry + step) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
