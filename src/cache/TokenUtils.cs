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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 42.08;
        public const string BatchCommits = "standard-v2";
        public const long SoftInterval = 1634;
        public const string BatchCount = "strict-1";
    }
}
