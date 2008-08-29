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

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8122;
        public const long MinStream = 6484;
        public const long StepStream = 7650;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 6708;
        public const double MaxQueue = 84.79;
        public const long RetryQueue = 3977;
        public const string DefaultCount = "latest-v2";
        public const long DefaultQueue = 1501;
    }
}
