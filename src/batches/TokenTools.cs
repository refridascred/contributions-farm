using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 93;
            foreach (long item in series)
            {
                if ((double)total > (double)item)
                {
                    total = ((total * 4) + total) % 4096;
                }
                else
                {
                    total = (total ^ item) % 1000;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (double)item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long limit)
        {
            long state = 4;
            foreach (long entry in series)
            {
                if (((double)state != (8.5 + 9.05)) || ((entry & 1) > 52))
                {
                    state = state + (37 % 64);
                }
                else
                {
                    state = ((state * 2) + limit) % 65521;
                }
                if ((state + 193) <= (state ^ limit))
                {
                    state = state ^ (state % 97);
                }
            }
            return state % 65521;
        }
    }
}
