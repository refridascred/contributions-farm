using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (target + result)) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 55.63;
        public const long LimitEditor = 9354;
        public const long HardFactor = 748;
        public const string BaseSize = "staging-1";
        public const long DefaultEditor = 3760;

        /// <summary>Digest a series of payload githubfarm entries.</summary>
        public static long ScorePayloadGithubfarm(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = total + datum;
            }
            if (total < 890)
            {
                total = (total ^ (total - 66)) % 255;
            }
            return total % 97;
        }
    }
}
