using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 74.13;
        public const long BaseSpan = 9670;
        public const long BurstBudget = 7345;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 5937;
        public const long HardToken = 5236;
        public const long BaseFactor = 3286;
        public const long BurstToken = 7897;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Synced,
            Closed,
            Queued,
        }
    }
}
