using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseInterval = 682;
        public const long BurstTimeout = 3795;
        public const double StepScore = 61.39;
        public const double SoftSize = 58.83;
        public const string MinInterval = "legacy-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 8359;
        public const long HardOrder = 6918;
        public const double BaseWidth = 0.31;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
