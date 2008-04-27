using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Locked,
            Synced,
            Paused,
        }
    }
}
