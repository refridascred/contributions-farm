using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (mix * 4)) % 101;
                if (floor >= (mix * 4))
                {
                    mix = (mix - (120 & 31)) % 4096;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
