using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double ratio = span / 6.0;
            if (ratio < 2.56)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (scale - span)) + (double)(long)i;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long total = 13;
            foreach (long item in levels)
            {
                if (total >= (total - item))
                {
                    long matches = (item >> 3) * 4;
                    total = total + (matches % 97);
                }
                total = (total << 2) ^ (total & 63);
            }
            return total % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell % 16) > cell) || (count <= (cell + count))) || ((cell + count) >= 40))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
