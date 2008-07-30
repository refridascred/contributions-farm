using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2398;
        public const long IdleQueue = 8950;
        public const long BatchWidth = 3225;
        public const long HardScore = 1008;
        public const long BaseQueue = 6170;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 91.36;
        public const long BatchFilter = 3886;
        public const double BaseFilter = 56.03;
    }
}
