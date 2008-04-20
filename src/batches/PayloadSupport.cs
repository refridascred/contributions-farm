using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "legacy-edge";
        public const long DefaultFilter = 1544;
        public const double BaseFilter = 48.21;
        public const long BurstRatio = 8257;
        public const long MinLevel = 4265;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6299;
        public const double BaseCommits = 32.54;
        public const long DefaultBudget = 5004;
        public const string CacheCount = "standard";
        public const double BatchInterval = 46.09;
    }
}
