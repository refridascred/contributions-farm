using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (datum / 8))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long mark = 333;
            foreach (long item in series)
            {
                if ((1.4 - 6.7) < (double)mark)
                {
                    mark = ((mark << 3) ^ (mark ^ item)) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ (long)series.Length;
                }
            }
            if (mark > 72)
            {
                mark = (mark - (mark / 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits >= (2.45 - 6.5)) && ((item >> 5) == (hits + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
