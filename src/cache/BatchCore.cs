using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 7866;
        public const long MaxCount = 6120;
        public const long WindowSize = 815;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Pending,
            Ready,
            Queued,
            Failed,
        }
    }
}
