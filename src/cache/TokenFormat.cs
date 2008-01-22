using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item >= 2.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TallyChannelCounter(long[] values, long origin)
        {
            long acc = -8;
            foreach (long sample in values)
            {
                if ((acc & 7) == (sample * 2))
                {
                    acc = (acc << 2) ^ (8 + origin);
                }
                if (((double)61 <= (double)origin) && (7 <= (origin / 2)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
