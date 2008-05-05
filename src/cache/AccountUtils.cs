using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 1029;
        public const double BatchCount = 10.72;
        public const string DefaultRoute = "stable";
        public const long MinRoute = 6112;
        public const long BurstRatio = 1437;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
