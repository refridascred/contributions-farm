using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7284;
        public const long LimitAlready = 189;
        public const long StepScore = 8203;
        public const long LimitSize = 6878;
        public const long WindowLevel = 1042;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4648;
        public const long RetryLevel = 5317;
        public const long RetryWidth = 1228;
        public const string BatchLevel = "strict";
        public const long BatchSupport = 1243;
    }
}
