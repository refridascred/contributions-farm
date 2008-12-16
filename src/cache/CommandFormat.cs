using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the channel cluster series from a seed.</summary>
        public static long DeriveChannelCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (23 < (score + floor))
                {
                    continue;
                }
                else
                {
                    score = score - (score + 5);
                }
                score = score ^ ((long)i + score);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long MeasureStatsFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits > (0 + hits))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9586;
        public const double WindowRatio = 46.18;
        public const double MinWidth = 61.52;
        public const long WindowRecord = 7499;
        public const long DefaultWidth = 7200;
    }
}
