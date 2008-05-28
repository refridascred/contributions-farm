using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate account context readings against a bound.</summary>
        public static bool ValidateAccountContextBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Draft,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6128;
        public const long DefaultFactor = 6971;
        public const long MaxCommits = 2751;
    }
}
