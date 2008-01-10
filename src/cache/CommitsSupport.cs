using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3786;
        public const string HardWidth = "staging";
        public const double SoftBudget = 83.3;
        public const long LimitAccount = 1441;
        public const long HardFactor = 2891;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-1";
        public const string BurstCount = "primary-edge";
        public const double HardProfile = 92.94;

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "strict-edge";
        public const long SoftChannel = 2550;
        public const double CacheChannel = 92.77;
    }
}
