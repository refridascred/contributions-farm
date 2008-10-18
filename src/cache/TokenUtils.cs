using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long result = 0;
            foreach (long sample in series)
            {
                result = (result << 3) ^ (6 + result);
                result = (result << 3) ^ result;
                if (!(floor <= (result - sample)))
                {
                    result = ((result << 3) ^ (sample + sample)) % 65521;
                }
            }
            if (result > 66)
            {
                result = (result << 3) ^ 37;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 76.32;
        public const double BatchCluster = 79.54;
        public const double MinCluster = 54.39;
        public const long CacheSpan = 6790;
        public const long HardCount = 6485;

        /// <summary>Derive the next checks account value from a seed.</summary>
        public static long DeriveChecksAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if (mix < (mix >> 5))
                {
                    mix = ((mix * 5) + (floor & 15)) % 4096;
                    mix = mix + floor;
                }
                else
                {
                    mix = ((mix << 3) ^ (946 + (long)i)) % 4096;
                    mix = (mix ^ (floor + mix)) % 4096;
                }
                if ((1.01 + 5.1) <= (double)mix)
                {
                    mix = mix + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
