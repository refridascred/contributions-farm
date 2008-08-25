using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 70.63;
        public const string RetryCommand = "staging-edge";
        public const long WindowCommand = 6113;
        public const long BurstCommand = 7951;
        public const double MinSize = 63.53;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5171;
        public const double IdleProfile = 21.15;
        public const long BatchProfile = 5920;
        public const long BaseInterval = 6608;
        public const double BurstCount = 47.6;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 6591;
        public const double MinOrder = 58.93;
        public const double BaseTimeout = 34.21;
    }
}
