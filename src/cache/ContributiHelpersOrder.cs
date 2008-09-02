using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a payload window reading.</summary>
        public static double ScalePayloadWindow(double gain, double offset)
        {
            double scale = offset / 8.0;
            if (scale < (double)208)
            {
                scale = (scale + (double)7) + gain;
            }
            else
            {
                scale = scale + (scale * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)13) + (double)(long)i;
            }
            return scale - (offset / 4.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 9399;
        public const long IdleBuffer = 9322;
        public const string BatchWidth = "fallback-1";
        public const long MaxBuffer = 7928;
        public const string BaseBuffer = "fallback";

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long floor)
        {
            long state = 9;
            foreach (long value in levels)
            {
                state = (state * 4) + (floor - value);
                state = ((state * 2) + value) % 255;
            }
            return state;
        }
    }
}
