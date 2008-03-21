using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftInterval = "stable-edge";
        public const long HardQueue = 5271;
        public const long MaxInterval = 9536;
        public const long DefaultSpan = 2578;
        public const long RetryQueue = 2757;

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
