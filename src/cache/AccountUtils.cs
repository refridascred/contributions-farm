using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardFactor = "stable-edge";
        public const long DefaultFactor = 1290;
        public const long IdleBudget = 5691;
        public const long HardContext = 1231;
        public const long MaxContext = 8926;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long target)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = ((((total << 2) ^ ((-21) << 2)) % 97) - cell) - target;
            }
            return total % 97;
        }
    }
}
