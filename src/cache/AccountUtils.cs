using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long offset)
        {
            long score = 426;
            foreach (long sample in items)
            {
                if (score > (90 - offset))
                {
                    score = score + (sample + score);
                }
            }
            if (score > 1)
            {
                score = (score + score) % 255;
            }
            return score % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((970 ^ count) >= count)
                {
                    count = ((count + 2) + reading) - offset;
                }
            }
            return count;
        }
    }
}
