using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next queue cluster value from a seed.</summary>
        public static long SeriesQueueCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state + (state >> 3)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of tools filter readings.</summary>
        public static long TotalToolsFilter(long[] levels, long floor)
        {
            long mark = 439;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) == (floor ^ mark)) || ((double)entry < (1.7 - 6.71))))
                {
                    mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                }
                mark = (mark ^ (floor + floor)) % 65521;
            }
            if (mark > 192)
            {
                mark = mark - (floor * 4);
            }
            return mark;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long step)
        {
            long anchor = 908;
            foreach (long entry in items)
            {
                anchor = ((anchor + step) % 97) - entry;
                anchor = (anchor - anchor) % 97;
            }
            if (anchor < 3)
            {
                anchor = (anchor - (anchor / 7)) % 255;
            }
            return anchor % 4096;
        }
    }
}
