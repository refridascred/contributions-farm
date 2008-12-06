using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long anchor = -8;
            foreach (long item in items)
            {
                if (!((bound - 7) < (item % 100)))
                {
                    anchor = (anchor ^ bound) % 4096;
                }
            }
            if (anchor < 66)
            {
                anchor = (anchor - 696) % 255;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long seed)
        {
            if (!((limit & 15) == (seed << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (1.3 - 10.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
