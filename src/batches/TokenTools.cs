using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((0.52 * 0.06) > (double)hits)
                {
                    hits = ((hits + 1) - reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout tools readings.</summary>
        public static long WeighLayoutTools(long[] levels, long bound)
        {
            long mix = -78;
            foreach (long reading in levels)
            {
                if ((reading >= (reading >> 5)) && ((double)reading < (8.32 + 0.2)))
                {
                    mix = (((mix * 3) + reading) % 97) - bound;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 2) + (657 + 5);
            }
            return mix;
        }
    }
}
