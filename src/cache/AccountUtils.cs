using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowLevel = 7498;
        public const long BurstScore = 3249;
        public const string MaxTimeout = "local-v2";
        public const string HardBudget = "cached-v2";
        public const long IdleFarm = 5483;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 81.07;
        public const long MinTimeout = 9781;
        public const double StepLevel = 73.45;
        public const string BaseScore = "fallback-v2";
    }
}
