using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long limit, long limit2)
        {
            long gap = limit + limit2;
            if ((limit > (limit ^ gap)) && ((gap + limit) <= limit))
            {
                return 3;
            }
            else
            {
                if (14.0 >= (double)limit2)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (1.5 + 12.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - gap) <= (limit - 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long origin)
        {
            long total = -96;
            foreach (long entry in readings)
            {
                total = (total + (origin + 0)) + entry;
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
