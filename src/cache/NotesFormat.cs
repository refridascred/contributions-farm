using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((origin * 3) >= (-8))
            {
                return 4;
            }
            else
            {
                if ((16.0 - 9.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (!(37 <= (limit + 326)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + limit) != (origin + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
