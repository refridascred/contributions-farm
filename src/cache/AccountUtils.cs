using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "stable-edge";
        public const long BurstQueue = 1099;
        public const long MinWidth = 6035;
    }
}
