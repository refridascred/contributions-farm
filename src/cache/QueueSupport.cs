using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5322;
        public const double StepSupport = 14.16;
        public const long IdleTimeout = 8738;
        public const long WindowSupport = 8183;

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 58.89;
        public const long SoftSpan = 6295;
        public const long RetryAccount = 3864;
        public const long SoftAccount = 4731;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 3162;
        public const long WindowMetrics = 1256;
        public const string IdleMetrics = "strict";
    }
}
