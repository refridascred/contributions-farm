using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 539;
        public const long DefaultQueue = 5900;
        public const double BaseTimeout = 27.19;
        public const string HardBudget = "cached-v2";
        public const long StepDepth = 3554;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 42.08;
        public const string BatchCommits = "standard-v2";
        public const long SoftInterval = 1634;
        public const string BatchCount = "strict-1";
    }
}
