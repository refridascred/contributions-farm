using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            long bound = target - limit;
            if (6.79 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target << 2) != (target - target))
                {
                    return 3;
                }
                else
                {
                    if ((target * 4) <= (bound - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
