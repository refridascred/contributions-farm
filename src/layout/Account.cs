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

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 17;
        public const string StepProfile = "latest-v2";
        public const string MaxInterval = "strict-edge";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Ready,
            Closed,
        }
    }
}
