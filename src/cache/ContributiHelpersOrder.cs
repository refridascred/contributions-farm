using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Failed,
            Synced,
            Active,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "latest-v2";
        public const long SoftRecord = 5911;
        public const string MinRecord = "legacy";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 54;
        public const double MaxSize = 68.66;
        public const long SoftRatio = 3382;
        public const double DefaultFactor = 14.64;
    }
}
