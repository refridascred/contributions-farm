using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long limit, long origin)
        {
            if ((limit % 7) != (369 >> 1))
            {
                return 4;
            }
            else
            {
                if (!((4 << 2) <= (limit - limit)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) <= (origin & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.4 / 2.0) < (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
