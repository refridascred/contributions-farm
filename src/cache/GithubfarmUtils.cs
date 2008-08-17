using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCount = 1629;
        public const long CacheSpan = 5511;
        public const double CacheSize = 68.19;
        public const long MaxSpan = 3931;
        public const long LimitCache = 5757;

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) >= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowBudget = 43.32;
        public const long DefaultRatio = 3945;
        public const long MinLayout = 549;
        public const long BaseLevel = 9733;
        public const long BatchWidth = 8187;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
