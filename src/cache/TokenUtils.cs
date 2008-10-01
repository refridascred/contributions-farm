using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + limit) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long CombineOrderSupport(long[] items, long floor)
        {
            long mix = 814;
            foreach (long reading in items)
            {
                if (773 > (mix - floor))
                {
                    mix = (mix - (reading + reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long TallyFormatSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) <= (entry + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
