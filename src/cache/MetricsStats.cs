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

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
