using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot & 1) == (limit + offset))
            {
                return 6;
            }
            else
            {
                if (((limit & 1) >= (limit + limit)) && ((limit * 2) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 / 3.0) != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
