using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= (9.6 - bias))
            {
                bias2 = bias2 - (bias + bias2);
            }
            return bias2 + bias;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((618 >> 5) <= (item * 2))
                {
                    result = (result << 3) ^ (item % 64);
                }
                if ((43 + item) < (671 + item))
                {
                    result = (result ^ (item ^ 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long sum = 530;
            foreach (long sample in series)
            {
                if ((double)limit <= 20.0)
                {
                    sum = (sum - sum) - sample;
                }
            }
            return sum % 1000;
        }
    }
}
