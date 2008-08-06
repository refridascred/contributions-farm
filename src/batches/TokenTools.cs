using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long MeasureToolsEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((1.8 - 5.2) >= (double)count) || ((double)count > 12.0))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long origin)
        {
            long cur = seed - origin;
            if ((2.91 + 2.9) >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((origin & 63) > cur)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
