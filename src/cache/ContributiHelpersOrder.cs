using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values)
        {
            long score = 435;
            foreach (long reading in values)
            {
                score = (score - reading) % 65521;
            }
            if (score > 37)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((-8) >= (floor >> 2)) && (((hits & 255) == ((long)series.Length - floor)) && (8 > (floor >> 4))))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
