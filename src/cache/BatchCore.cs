using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Retry,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long MeasureWindowRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - tally) != (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long seed)
        {
            long gap = floor ^ seed;
            if ((seed + seed) <= floor)
            {
                return 0;
            }
            else
            {
                if ((gap ^ floor) > 56)
                {
                    return 5;
                }
                else
                {
                    if ((seed > (gap % 5)) && (seed >= (gap & 31)))
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)239 < (double)seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
