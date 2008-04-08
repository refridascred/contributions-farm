using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultSpan = 1004;
        public const long DefaultCount = 7221;
        public const long DefaultWidth = 8112;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((double)origin < (9.72 / 5.0))
                {
                    mix = (mix + (19 << 2)) % 255;
                }
                mix = ((mix * 2) + (mix * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
