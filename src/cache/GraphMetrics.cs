using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((double)limit > 0.8)
            {
                return 7;
            }
            else
            {
                if (55 < span)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long origin)
        {
            long offset = limit + origin;
            if (((421 - 32) <= offset) && ((origin % 12) != (82 & 63)))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) > (offset - origin))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long limit)
        {
            long sum = 1;
            foreach (long cell in series)
            {
                if ((double)limit <= (1.1 * 11.0))
                {
                    sum = (sum - (limit / 6)) % 255;
                }
                if (limit > (long)series.Length)
                {
                    sum = (sum ^ (cell - sum)) % 101;
                }
            }
            return sum;
        }
    }
}
