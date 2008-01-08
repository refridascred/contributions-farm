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

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)offset < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
