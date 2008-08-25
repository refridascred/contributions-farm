using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 46.98;
        public const string IdleEditor = "open-v2";
        public const double StepEditor = 89.36;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 6591;
        public const double MinOrder = 58.93;
        public const double BaseTimeout = 34.21;
    }
}
