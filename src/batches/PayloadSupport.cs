using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "alpha";
        public const long BatchWidth = 6543;
        public const long BurstBudget = 3940;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
