using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 92.62;
        public const string MaxScore = "local-edge";
        public const long BaseCache = 5442;
        public const long BatchBudget = 5423;
        public const long StepSpan = 5104;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Closed,
            Done,
            Idle,
            Stale,
        }
    }
}
