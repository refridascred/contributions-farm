using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - hits) < (floor * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long MatchBufferLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long acc = 5;
            foreach (long entry in samples)
            {
                if ((902 - entry) >= entry)
                {
                    acc = (acc + entry) + floor;
                    continue;
                }
                acc = ((acc << 2) ^ 71) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                if ((612 >> 5) >= entry)
                {
                    carry = (carry * 5) + (carry - 4);
                }
                else
                {
                    carry = carry - entry;
                }
                carry = carry + (628 ^ carry);
            }
            return carry;
        }
    }
}
