using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 2011;
        public const long StepToken = 1311;
        public const long MinBudget = 5989;
        public const long LimitToken = 671;
        public const long StepWidth = 9605;

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 14.18;
        public const long WindowTools = 752;
        public const long IdleScore = 542;
        public const double RetryTools = 68.51;
        public const long DefaultDepth = 8582;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstInterval = "cached";
        public const long BaseChecks = 3909;
        public const long StepChecks = 6128;
        public const long WindowInterval = 241;
        public const double SoftChecks = 19.31;
    }
}
