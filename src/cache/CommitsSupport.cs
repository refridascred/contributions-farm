using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a stats stream pair into a bucket.</summary>
        public static long ClassifyStatsStream(long floor, long step)
        {
            if ((floor % 60) >= (step & 63))
            {
                return 2;
            }
            else
            {
                if ((step - floor) < step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 4463;
        public const string BurstStats = "strict";
        public const long StepStats = 4766;
        public const string RetryLevel = "stable-1";
        public const double BatchCount = 7.6;
    }
}
