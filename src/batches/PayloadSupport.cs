using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 53.3;
        public const long RetryBudget = 5590;
        public const long IdleToken = 7008;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchLevel = 2671;
        public const long DefaultChecks = 5220;
        public const long StepChecks = 419;
        public const string WindowChecks = "legacy-v2";
    }
}
