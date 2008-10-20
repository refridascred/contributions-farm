using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepRatio = "local-1";
        public const double IdleSpan = 58.82;
        public const long MaxScore = 6376;
        public const long IdleWidth = 8893;
        public const long BurstMetrics = 4351;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
