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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((offset << 3) <= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5994;
        public const long MinContext = 913;
        public const long WindowContext = 546;
    }
}
