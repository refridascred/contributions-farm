using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 122;
            foreach (long reading in items)
            {
                if (score <= (score - score))
                {
                    score = (score - (reading & 255)) % 1000;
                }
                if ((double)7 <= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - count) >= (origin - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
