using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)hits <= (double)79) && !((item + 4) >= (item & 255)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long RollChannelSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
