using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local-edge";
        public const long WindowRatio = 3176;
        public const string StepEntry = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7606;
        public const long CacheLevel = 5905;
        public const long WindowScore = 4078;
        public const long BurstInterval = 2065;
        public const long BatchFormat = 4117;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + 736) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
