using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 112;
        public const long CacheWindow = 7024;
        public const long DefaultLevel = 3012;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "strict-v2";
        public const long MaxFarm = 1893;
        public const long HardFarm = 4098;
        public const long CacheFarm = 1604;
        public const double BaseScore = 42.01;
    }
}
