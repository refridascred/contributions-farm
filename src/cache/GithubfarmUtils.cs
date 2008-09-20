using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long PairEntryCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((19.0 - 2.9) < (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values, long offset)
        {
            long total = 796;
            foreach (long value in values)
            {
                if ((offset + 82) >= (value & 31))
                {
                    total = ((total << 2) ^ (offset >> 5)) % 4096;
                }
            }
            if (total > 47)
            {
                total = (total ^ (offset & 15)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long limit, long origin)
        {
            long cur = limit - origin;
            if (cur < limit)
            {
                return 8;
            }
            else
            {
                if ((9.8 + 19.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((limit - origin) > (cur * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
