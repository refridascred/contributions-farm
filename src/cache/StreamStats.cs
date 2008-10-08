using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (offset - mix)) % 1000;
                mix = ((mix << 3) ^ (405 + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) <= (hits % 10))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings, long limit)
        {
            long state = 589;
            foreach (long item in readings)
            {
                if ((state & 7) < (limit / 2))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state - (state - state)) % 97;
                }
            }
            return state;
        }
    }
}
