using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 5219;
        public const long BurstNotes = 958;
        public const long CacheNotes = 2135;
        public const long WindowNotes = 9866;
        public const long StepInterval = 3201;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitInterval = 8952;
        public const long IdleBudget = 7336;
        public const long IdleCount = 6455;
        public const string WindowDepth = "local";

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 85.03;
        public const double StepOrder = 75.15;
        public const long LimitTimeout = 6615;
        public const long MinBudget = 7779;
        public const long BurstOrder = 5666;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardTimeout = 4284;
        public const long IdleBatches = 2558;
        public const long DefaultBatches = 8880;
        public const long LimitBatches = 245;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Locked,
            Active,
        }
    }
}
