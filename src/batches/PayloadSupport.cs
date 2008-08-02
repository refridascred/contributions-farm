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

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftScore = 1190;
        public const long HardRecord = 8384;
        public const long DefaultScore = 7843;
        public const string MinRecord = "primary-v2";

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
