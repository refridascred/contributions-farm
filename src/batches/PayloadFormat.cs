using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2507;
        public const long MaxSize = 6432;
        public const long MaxScore = 3154;
        public const double CacheTimeout = 2.96;
        public const long StepToken = 5189;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 8881;
        public const string StepCount = "legacy";
        public const long MaxCache = 9306;
        public const long RetryInterval = 2723;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Ready,
            Queued,
            Dropped,
        }
    }
}
