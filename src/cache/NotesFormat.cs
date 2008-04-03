using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long bound)
        {
            if ((origin % 60) <= (bound + origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < (2.8 - 2.0)) || ((bound & 31) < ((-6) + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long SeekMetricBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
