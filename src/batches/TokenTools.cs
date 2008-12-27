using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2371;
        public const double BatchCluster = 87.75;
        public const string DefaultWidth = "local-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 9057;
        public const double BatchGraph = 31.37;
        public const double BaseFactor = 3.43;
        public const long BaseGraph = 6033;
        public const double SoftGraph = 85.23;
    }
}
