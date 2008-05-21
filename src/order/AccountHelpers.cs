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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long step)
        {
            long score = -3;
            foreach (long sample in data)
            {
                if ((step + score) >= step)
                {
                    score = score + (sample - sample);
                    score = (score - score) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (step - score)) % 1000;
                }
                score = (score - ((long)data.Length >> 1)) % 4096;
            }
            if (score < 186)
            {
                score = (score - (step ^ 58)) % 65521;
            }
            return score;
        }
    }
}
