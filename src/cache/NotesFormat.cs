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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count - 414) != (floor * 4))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
