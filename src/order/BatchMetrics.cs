using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Locked,
            New,
            Idle,
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] data, long limit)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((9.1 + 17.0) > (double)limit) && ((entry ^ result) >= limit))
                {
                    result = result ^ (result % 60);
                }
                if ((result + result) != (entry & 15))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = result + (limit + result);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long mix = 333;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 5) + item) + bound;
            }
            return mix;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long AuditToolsFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + seen) > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
