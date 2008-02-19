using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((17 & 7) != (count >> 1))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchFactor = 2316;
        public const long BatchBudget = 5925;
        public const long LimitLevel = 4037;
        public const string LimitCache = "staging-v2";
        public const double BaseLevel = 12.78;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((offset & 7) >= offset)
            {
                return 7;
            }
            else
            {
                if (offset < (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((limit + offset) > offset) && ((double)limit != (8.0 - 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 3) <= (bound - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}
