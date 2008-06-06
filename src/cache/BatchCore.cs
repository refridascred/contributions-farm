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

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long ScoreCommitsFilter(long[] data, long origin)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (mark >> 4)) - origin;
                mark = ((mark * 2) + (item * 5)) % 255;
            }
            return mark;
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
