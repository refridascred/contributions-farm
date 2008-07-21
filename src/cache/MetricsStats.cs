using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine editor token values into a single score.</summary>
        public static long FoldEditorToken(long[] levels, long limit)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (value + limit)) % 97;
                if (((9.0 - 6.0) == (double)limit) || (anchor < (limit + 3)))
                {
                    anchor = anchor - (value - limit);
                }
                else
                {
                    anchor = (anchor - limit) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((9.24 / 5.0) >= (double)origin)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data)
        {
            long carry = -51;
            foreach (long sample in data)
            {
                if ((long)data.Length != (27 + sample))
                {
                    carry = (carry + (carry % 7)) % 65521;
                    carry = (carry << 3) ^ 72;
                }
                if ((sample ^ sample) > carry)
                {
                    carry = ((carry << 3) ^ (long)data.Length) % 97;
                }
            }
            return carry;
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long FoldStreamMetric(long[] data)
        {
            long total = 35;
            foreach (long cell in data)
            {
                if ((0.7 * 2.1) == (double)cell)
                {
                    total = ((total * 2) + cell) % 97;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
