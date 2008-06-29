using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "cached";
        public const long WindowLevel = 9431;
        public const long BurstDepth = 4862;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Iterate the account farm series from a seed.</summary>
        public static long IterateAccountFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a payload schema counter forward.</summary>
        public static long SeriesPayloadSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
