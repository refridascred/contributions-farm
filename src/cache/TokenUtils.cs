using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 1546;
        public const long LimitFactor = 7485;
        public const long MaxContext = 3899;
        public const string WindowContext = "standard-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Draft,
            Active,
            New,
        }
    }
}
