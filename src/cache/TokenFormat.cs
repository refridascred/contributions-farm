using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 40.25;
        public const long RetryBatch = 2830;
        public const string DefaultBatch = "primary-edge";
        public const string SoftCount = "local";

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "cached";
        public const string BaseRatio = "stable-v2";
        public const double SoftCommand = 21.96;
        public const string StepBudget = "stable";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
