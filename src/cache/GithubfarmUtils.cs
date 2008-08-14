using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9740;
        public const long MaxLayout = 8309;
        public const long BurstTimeout = 4882;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc + (item & 1)) % 1000;
                acc = (acc << 2) ^ 8;
                if (item <= (5 << 2))
                {
                    acc = (acc << 3) ^ (acc % 60);
                }
            }
            if (acc < (-28))
            {
                acc = (acc ^ (acc << 2)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5994;
        public const long MinContext = 913;
        public const long WindowContext = 546;
    }
}
