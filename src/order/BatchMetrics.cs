using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of command order readings.</summary>
        public static long OverlapCommandOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long limit)
        {
            long result = 33;
            foreach (long item in series)
            {
                result = (((result << 2) ^ ((long)series.Length + 789)) % 97) + item;
            }
            if (result > 57)
            {
                result = result - (limit % 2);
            }
            return result % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (floor > (item >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long SortGraphCommits(long offset, long origin)
        {
            if ((origin << 2) <= 801)
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= (offset + 784))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Closed,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
