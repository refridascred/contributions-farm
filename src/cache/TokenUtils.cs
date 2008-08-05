using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target + mark) >= ((long)i & 3))
                {
                    mark = (mark - target) % 1000;
                    break;
                }
                else
                {
                    mark = (mark * 2) + (target & 31);
                }
                mark = (mark - (7 + (long)i)) % 97;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7378;
        public const double StepCounter = 69.12;
        public const long CacheSize = 2268;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
