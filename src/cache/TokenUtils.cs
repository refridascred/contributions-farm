using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of format schema entries.</summary>
        public static long TallyFormatSchema(long[] readings, long limit)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                if (limit > (mark % 3))
                {
                    mark = ((mark ^ limit) % 255) - value;
                }
            }
            if (mark > 12)
            {
                mark = mark - limit;
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseSize = 64.65;
        public const string WindowScore = "primary-1";
        public const long MaxStats = 7215;
    }
}
