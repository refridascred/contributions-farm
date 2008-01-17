using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 6708;
        public const long IdleScore = 675;
        public const long LimitBuffer = 774;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 4949;
        public const long CacheTimeout = 4953;
        public const long BaseNotes = 6678;
    }
}
