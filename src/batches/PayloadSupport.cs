using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultLevel = "primary-1";
        public const string MaxCache = "legacy-1";
        public const long BatchCache = 8315;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2857;
        public const long BaseCache = 4388;
        public const long LimitLevel = 8424;
        public const string StepCache = "strict";
    }
}
