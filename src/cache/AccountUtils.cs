using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen >> 5) >= (step << 3))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowLevel = "primary-1";
        public const long LimitWidth = 2582;
        public const string DefaultSize = "local-1";
        public const long BurstFactor = 506;
        public const long HardContributi = 6601;

        /// <summary>Validate already cache readings against a bound.</summary>
        public static bool ValidateAlreadyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
