using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 4755;
        public const double MinCommits = 90.74;
        public const double IdleCount = 89.3;
        public const long CacheFactor = 3690;
        public const string BaseCommits = "latest";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
