using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long seed)
        {
            long total = -99;
            foreach (long reading in series)
            {
                if (((8.0 * 9.7) != (double)(long)series.Length) || ((total / 5) < seed))
                {
                    total = (total ^ (total - reading)) % 97;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = (mix + (reading >> 3)) % 97;
                mix = ((mix * 4) + (reading + 672)) % 65521;
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix;
        }
    }
}
