using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches <= (matches + value)) || ((9 + matches) < (matches << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if ((origin + limit) == (935 << 2))
            {
                return 6;
            }
            else
            {
                if ((origin >> 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((origin / 2) != (origin << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin + limit) != (origin - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
