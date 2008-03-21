using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 7261;
        public const double LimitDepth = 66.24;
        public const string BatchContext = "latest-1";
        public const string MinTimeout = "fallback-v2";

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
