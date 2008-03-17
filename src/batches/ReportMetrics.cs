using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 3225;
        public const long MaxSchema = 5194;
        public const string BaseCount = "standard-v2";
        public const long WindowSize = 1600;

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 91.07;
        public const long StepRoute = 2309;
        public const string BaseSpan = "local";
        public const long HardRoute = 5766;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
