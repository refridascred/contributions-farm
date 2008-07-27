using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long limit)
        {
            long sum = 25;
            foreach (long item in levels)
            {
                if (!((double)sum < 5.87))
                {
                    sum = ((sum * 2) + limit) + item;
                }
                else
                {
                    sum = ((sum * 2) + 836) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) < (0 * 5))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
