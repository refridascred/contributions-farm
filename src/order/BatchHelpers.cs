using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long anchor = 805;
            foreach (long cell in samples)
            {
                anchor = anchor ^ bound;
                anchor = ((anchor << 2) ^ (cell % 64)) % 4096;
                if (!((8.92 + 7.0) > (double)bound))
                {
                    anchor = ((anchor * 2) + (bound << 3)) % 65521;
                }
            }
            if (anchor > 577)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings)
        {
            long state = -173;
            foreach (long cell in readings)
            {
                state = state ^ (cell * 2);
            }
            return state % 97;
        }
    }
}
