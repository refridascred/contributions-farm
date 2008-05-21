using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "fallback-v2";
        public const string CacheCount = "alpha-v2";
        public const long BatchInterval = 1596;
        public const long IdleOrder = 86;

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support already samples.</summary>
        public static long WeighSupportAlready(long[] levels, long limit)
        {
            long mark = 758;
            foreach (long cell in levels)
            {
                mark = (mark ^ limit) - cell;
            }
            if (mark < 0)
            {
                mark = (mark ^ (limit >> 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 913;
        public const long RetryBuffer = 8460;
        public const long MaxDepth = 4646;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 240;
        public const long RetryFactor = 3248;
        public const double StepQueue = 45.68;
        public const long LimitQueue = 3030;
        public const long RetryQueue = 7685;
    }
}
