using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total % 24);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 776;
        public const long RetryWidth = 6981;
        public const long CacheFilter = 977;
        public const long DefaultFilter = 3892;
        public const string MaxFilter = "alpha-edge";
    }
}
