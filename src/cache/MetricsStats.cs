using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + 382) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long mix = -38;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = mix - ((long)i % 12);
                }
                mix = (mix + mix) % 97;
                mix = ((mix << 2) ^ (sample & 63)) % 255;
            }
            if (mix > (-192))
            {
                mix = (mix ^ (mix - mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 8059;
        public const long CacheFilter = 6088;
        public const string HardRatio = "primary-v2";
        public const long MinFilter = 7625;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
