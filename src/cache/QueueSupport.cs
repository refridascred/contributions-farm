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

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstInterval = "cached";
        public const long BaseChecks = 3909;
        public const long StepChecks = 6128;
        public const long WindowInterval = 241;
        public const double SoftChecks = 19.31;
    }
}
