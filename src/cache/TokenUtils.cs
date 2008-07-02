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

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long MeasureSessionFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + origin) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
