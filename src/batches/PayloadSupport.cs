using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7351;
        public const string HardBatches = "primary";
        public const string MinBatches = "local-1";
        public const long BatchTimeout = 5637;
        public const double DefaultBatches = 79.28;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Active,
        }
    }
}
