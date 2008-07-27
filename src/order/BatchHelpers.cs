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

        /// <summary>Derive the next command token value from a seed.</summary>
        public static long RollCommandToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor / 5) >= floor)
                {
                    total = total - floor;
                    continue;
                }
                total = total + (89 >> 4);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches ^ 2) == (matches / 2))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
