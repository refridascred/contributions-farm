using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 6166;
        public const long BaseSchema = 3735;
        public const long BaseScore = 1402;
        public const double SoftLevel = 53.06;
        public const long LimitLevel = 2017;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
