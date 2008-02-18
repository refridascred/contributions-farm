using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long target)
        {
            if ((target % 100) > target)
            {
                return 3;
            }
            else
            {
                if (target > (target - target))
                {
                    return 8;
                }
                else
                {
                    if ((9.2 * 9.87) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 9322;
        public const double IdleBudget = 72.39;
        public const string MaxSupport = "stable-v2";

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score << 2) ^ (score & 15);
                long offset = (origin + score) >> 1;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (origin >> 5)) % 97) ^ (long)i2;
                    score = score - (offset ^ (long)i);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
