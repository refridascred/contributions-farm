using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 7673;
        public const long HardMetrics = 7915;
        public const long BurstMetrics = 4673;
        public const long SoftInterval = 8519;
        public const double IdleMetrics = 83.75;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 9892;
        public const string HardInterval = "primary-1";
        public const double BatchDepth = 3.91;
        public const long HardDepth = 8751;
        public const long BurstAlready = 4162;
    }
}
