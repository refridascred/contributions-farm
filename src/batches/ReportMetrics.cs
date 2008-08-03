using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxScore = 55.42;
        public const string WindowSize = "staging-edge";
        public const long DefaultBudget = 5583;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Ready,
            Idle,
        }
    }
}
