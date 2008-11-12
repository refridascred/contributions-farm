using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Idle,
            Closed,
            Failed,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6278;
        public const long BatchAccount = 4633;
        public const string SoftAccount = "open-v2";
    }
}
