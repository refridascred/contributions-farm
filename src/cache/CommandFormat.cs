using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every graph queue entry stays within the limit.</summary>
        public static bool ValidateGraphQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((double)hits <= 1.8) && !((136 >> 4) <= (cell * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + mark) % 65521;
                if (!((double)966 != (double)mark))
                {
                    mark = (mark - mark) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (mark & 15)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const string SoftReport = "stable-edge";
        public const double MinReport = 53.44;
        public const long SoftSpan = 9811;
    }
}
