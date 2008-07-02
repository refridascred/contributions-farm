using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-v2";
        public const double HardBatch = 24.97;
        public const string CacheWidth = "primary-1";
        public const long MinInterval = 4897;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset * 5.5)) + (double)(long)i;
            }
            return drift + (double)26;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            if ((11.0 / 4.0) == (double)target)
            {
                return 6;
            }
            else
            {
                if ((offset + 94) < (offset & 7))
                {
                    return 0;
                }
                else
                {
                    if ((7.8 / 2.0) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
