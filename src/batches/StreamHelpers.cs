using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the context tools series from a seed.</summary>
        public static long SeriesContextTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (target - (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long limit)
        {
            long anchor = 565;
            foreach (long entry in levels)
            {
                anchor = ((anchor + (anchor - anchor)) ^ entry) - limit;
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally > (5.18 - 5.0))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long state = -40;
            foreach (long cell in series)
            {
                state = ((state + state) % 101) - cell;
                state = state - (state >> 4);
            }
            return state % 65521;
        }
    }
}
