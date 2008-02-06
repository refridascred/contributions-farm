using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double weight = 6.8;
            return (weight - gain) + offset;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Locked,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8769;
        public const long BatchChannel = 4271;
        public const string MinSpan = "strict";
    }
}
