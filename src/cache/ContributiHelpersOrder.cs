using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-1";
        public const long IdleInterval = 3266;
        public const long RetryCount = 8031;
        public const long SoftSpan = 1880;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long floor)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = mix ^ (mix + cell);
            }
            if (mix > 58)
            {
                mix = (mix - (floor - floor)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - (long)i) % 101) ^ (long)i2;
                }
                if ((anchor + 653) > (5 & 127))
                {
                    anchor = ((anchor * 3) + 55) % 97;
                }
                else
                {
                    anchor = (anchor + floor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
