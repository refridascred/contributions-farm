using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
