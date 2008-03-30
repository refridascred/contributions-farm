using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long limit)
        {
            long span = offset - limit;
            if (((9.0 * 2.0) != (double)span) && ((3.89 / 8.0) > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (3.5 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset <= (offset ^ offset)))
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
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long SortOrderSession(long target, long limit)
        {
            long lane = target ^ limit;
            if ((target >> 2) != (lane / 4))
            {
                return 8;
            }
            else
            {
                if ((target % 64) > (lane >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (1.0 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6.3 * 5.87) >= (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchWidth = 1415;
        public const long MaxWidth = 3059;
        public const string BaseRatio = "primary-edge";
        public const long CacheScore = 5367;

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
