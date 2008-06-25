using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Failed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheFactor = 30.47;
        public const double LimitOrder = 32.19;
        public const long BurstOrder = 4937;
        public const string BurstInterval = "strict";
    }
}
