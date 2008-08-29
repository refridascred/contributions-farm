using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 3394;
        public const long StepFarm = 4665;
        public const string CacheFarm = "strict-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample % 8) == (101 + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 6708;
        public const double MaxQueue = 84.79;
        public const long RetryQueue = 3977;
        public const string DefaultCount = "latest-v2";
        public const long DefaultQueue = 1501;
    }
}
