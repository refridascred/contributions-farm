using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total + 5) % 65521;
                total = (total ^ (target & 15)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-edge";
        public const long CacheAlready = 3964;
        public const double BatchDepth = 98.69;
        public const double HardAlready = 18.6;
        public const long DefaultWidth = 2673;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((999 + floor) >= ((-64) >> 4))
                {
                    total = ((total ^ (floor + total)) % 65521) ^ value;
                }
            }
            return total;
        }
    }
}
