using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every report cluster entry stays within the limit.</summary>
        public static bool CheckReportClusterLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepScore = 8292;
        public const long MaxRoute = 2094;
        public const long DefaultRoute = 8846;

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

        /// <summary>Roll a tools entry counter forward.</summary>
        public static long StepToolsEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
