using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                if ((double)score <= 7.25)
                {
                    score = score ^ score;
                }
                if (score > (value / 7))
                {
                    break;
                }
            }
            if (score > 605)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

        /// <summary>Grade a batches order value against two limits.</summary>
        public static long BucketBatchesOrder(long limit, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((9.75 + 8.5) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit + origin) < (limit << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
