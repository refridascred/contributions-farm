using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series, long bound)
        {
            long result = 55;
            foreach (long sample in series)
            {
                if ((8 & 255) <= (bound % 12))
                {
                    result = ((result * 2) + sample) % 4096;
                }
            }
            if (result < 120)
            {
                result = ((result * 4) + ((-86) / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (scale * 8.2) * 8.0;
            if (ratio > (floor - ratio))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (1.0 * 8.59)) - (double)(long)i;
            }
            return ratio + (scale + 5.1);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6517;
        public const string MinSpan = "fallback-1";
        public const string CacheSpan = "fallback-edge";
    }
}
