using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 845;
        public const string MinRecord = "legacy-1";
        public const long IdleFactor = 6026;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 6253;
        public const string BatchInterval = "cached-v2";
        public const string DefaultMetric = "primary-edge";

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
