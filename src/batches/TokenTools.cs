using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)target <= (3.2 * 2.18))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 53.88;
        public const long BaseFormat = 4477;
        public const string MaxFormat = "standard";
        public const string RetryFactor = "open";
        public const long MinCount = 8747;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "open";
        public const double DefaultTimeout = 72.62;
        public const long MinPayload = 6224;
    }
}
