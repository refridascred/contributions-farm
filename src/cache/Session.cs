using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 506;
        public const double SoftMetric = 56.5;
        public const double BurstMetric = 53.25;
        public const double LimitTimeout = 85.57;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Pending,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                long step = (822 >> 4) - (seed - anchor);
                if (step >= seed)
                {
                    step = ((step * 3) + (step + (long)i)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "primary-edge";
        public const long RetrySize = 4583;
        public const long DefaultRatio = 2973;
    }
}
