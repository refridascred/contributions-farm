using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long TotalBufferTools(long[] values, long limit)
        {
            long anchor = -34;
            foreach (long value in values)
            {
                if ((anchor > (6 * 4)) && (anchor <= (value - value)))
                {
                    anchor = ((anchor * 2) + (limit - anchor)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor - (limit + 335)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue farm value from a seed.</summary>
        public static long IterateQueueFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
