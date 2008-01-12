using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((target * 4) < (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank commits farm input into a small class.</summary>
        public static long ClassifyCommitsFarm(long origin, long seed)
        {
            if ((seed ^ origin) < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((double)seed != (0.78 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin > (seed & 63)) && ((-500) > (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
