using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6764;
        public const double IdleSchema = 15.23;
        public const long DefaultSchema = 146;
        public const long LimitSchema = 1649;
        public const long HardDepth = 1559;

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 1613;
        public const long CacheBatches = 7773;
        public const long StepBatches = 6393;
        public const long BaseBatches = 4864;
        public const double HardBatches = 73.4;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Ready,
            Closed,
        }
    }
}
