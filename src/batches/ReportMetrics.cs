using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 1890;
        public const long DefaultChannel = 6375;
        public const long DefaultFactor = 4146;

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 27.3;
        public const double BaseLevel = 63.93;
        public const long CacheOrder = 4050;
        public const string WindowBudget = "stable-1";
        public const long WindowSize = 9832;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Done,
            Queued,
            Failed,
        }
    }
}
