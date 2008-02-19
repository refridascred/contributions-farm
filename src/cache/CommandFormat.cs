using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (seed > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double scale = (double)(371 / 5);
            if (scale < (18.0 + offset))
            {
                scale = (scale - (1.0 / 9.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (7.9 * 8.9);
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            if (!((double)limit == (1.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((9.05 + 0.66) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
