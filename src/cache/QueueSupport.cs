using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6963;
        public const long DefaultBudget = 185;
        public const string StepSpan = "fallback";
        public const long DefaultCache = 9895;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchCount = 3263;
        public const string MinToken = "primary";
        public const string BurstToken = "strict";
        public const string MaxToken = "open-edge";
    }
}
