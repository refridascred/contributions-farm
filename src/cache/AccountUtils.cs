using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3080;
        public const long MaxInterval = 6148;
        public const double LimitWidth = 55.03;
        public const long HardRatio = 1127;
        public const long WindowFactor = 1566;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Ready,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }
    }
}
