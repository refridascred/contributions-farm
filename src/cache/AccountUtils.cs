using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 886;
        public const double RetryRoute = 55.31;
        public const long WindowRoute = 1846;
        public const string StepLevel = "legacy";

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
