using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph queue readings against a rule.</summary>
        public static long AuditGraphQueueOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 1) < (7 % 3))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long OverlapSchemaFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)step != (7.0 + 1.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long target)
        {
            if (8.3 > (double)floor)
            {
                return 8;
            }
            else
            {
                if (((floor & 3) >= (4 ^ floor)) || ((floor + floor) >= target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
