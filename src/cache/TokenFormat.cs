using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheLevel = 22.0;
        public const long HardGraph = 1906;
        public const double MaxGraph = 80.33;
        public const string BatchBudget = "fallback";

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitDepth = 6356;
        public const long BurstRecord = 1699;
        public const string MaxDepth = "latest-1";
        public const double StepRecord = 29.39;
        public const double LimitLevel = 71.93;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
