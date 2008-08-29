using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi metrics input into a small class.</summary>
        public static long BucketContributiMetrics(long floor, long seed)
        {
            if ((seed + seed) >= (floor % 60))
            {
                return 1;
            }
            else
            {
                if (((seed - seed) == (floor << 2)) && ((floor - 398) <= seed))
                {
                    return 0;
                }
                else
                {
                    if (floor <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Failed,
            Queued,
            Retry,
            Ready,
        }
    }
}
