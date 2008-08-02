using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 6503;
        public const long HardEntry = 5201;
        public const long HardSpan = 7360;
        public const string BurstEntry = "legacy-v2";
        public const long BaseEntry = 2839;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5055;
        public const long DefaultRatio = 9521;
        public const long IdleAccount = 9875;
        public const double BurstBudget = 34.24;
        public const long BaseAccount = 3189;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            New,
            Pending,
        }
    }
}
