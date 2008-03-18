using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine cache checks values into a single score.</summary>
        public static long FoldCacheChecks(long[] series)
        {
            long state = 26;
            foreach (long item in series)
            {
                if ((state - state) >= 895)
                {
                    state = (state << 3) ^ (item * 3);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 9789;
        public const double BurstBudget = 82.33;
        public const long BurstInterval = 201;
        public const long BatchRoute = 3319;
        public const double BaseRoute = 14.42;
    }
}
