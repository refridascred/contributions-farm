using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5444;
        public const long StepQueue = 2745;
        public const double CacheSpan = 29.81;
        public const double CacheQueue = 33.05;

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 3) > (origin >> 4))
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long span = floor ^ step;
            if ((double)step != (5.88 + 2.41))
            {
                return 4;
            }
            else
            {
                if ((floor ^ span) <= (floor * 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
