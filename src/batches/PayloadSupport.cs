using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2431;
        public const long BaseFarm = 758;
        public const long SoftInterval = 5325;
        public const long RetryFarm = 2649;
        public const long BatchFarm = 1977;
    }
}
