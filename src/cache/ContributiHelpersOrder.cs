using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long diff = limit - target;
            if (!(target >= (63 >> 4)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (6.59 >= (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
