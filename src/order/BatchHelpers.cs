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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Synced,
            Active,
            New,
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
