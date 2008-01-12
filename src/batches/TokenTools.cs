using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 3) != (hits * 2))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if ((datum ^ score) != (score - datum))
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
