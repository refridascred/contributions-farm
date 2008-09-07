using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long origin)
        {
            long acc = 48;
            foreach (long datum in series)
            {
                if ((1.8 * 6.8) == (double)origin)
                {
                    acc = acc - 144;
                }
                else
                {
                    acc = ((acc * 4) + (datum >> 1)) % 4096;
                }
            }
            if (acc > 306)
            {
                acc = (acc - (2 >> 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!!((6.24 + 11.0) <= (double)result))
                {
                    result = (result - (bound + bound)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
