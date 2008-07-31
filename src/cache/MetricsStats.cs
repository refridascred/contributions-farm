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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
