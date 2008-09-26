using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 68.9;
        public const string HardGraph = "alpha-edge";
        public const string LimitSpan = "legacy-edge";
        public const double LimitGraph = 80.05;

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 67.76;
        public const long DefaultFactor = 4323;
        public const string WindowFormat = "alpha-v2";
        public const long MaxFactor = 5694;
        public const string BatchRatio = "latest";
    }
}
