using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < 14.0)
            {
                scale2 = (scale2 + (scale2 + 9.06)) + offset;
            }
            return scale2 - (18.0 / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "strict-v2";
        public const double HardFactor = 81.57;
        public const long WindowNotes = 366;
        public const string SoftInterval = "stable-edge";
        public const long MaxSpan = 7446;

        /// <summary>Find the first account cache entry that matches the target.</summary>
        public static long SeekAccountCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
