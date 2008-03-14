using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long CountCommandEditorMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((0 << 3) < (bound * 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Match up queue cache samples.</summary>
        public static long OverlapQueueCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = score - step;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
