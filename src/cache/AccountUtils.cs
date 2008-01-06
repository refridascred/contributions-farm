using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2740;
        public const string LimitRatio = "legacy-edge";
        public const string DefaultSize = "stable-1";
        public const long WindowSupport = 6183;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultDepth = 3481;
        public const double LimitBatch = 54.37;
        public const double BaseWidth = 71.7;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = total + ((long)i & 15);
                total = total - (total * 2);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
