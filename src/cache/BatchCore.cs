using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Failed,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate batches batch samples.</summary>
        public static long CombineBatchesBatch(long[] items, long origin)
        {
            long acc = 173;
            foreach (long reading in items)
            {
                if (((19.0 + 6.0) >= (double)origin) && (reading <= (reading >> 4)))
                {
                    acc = (acc * 5) + reading;
                }
                else
                {
                    acc = ((acc << 2) ^ reading) % 1000;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (origin + origin)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of report context readings.</summary>
        public static long ScoreReportContext(long[] readings)
        {
            long result = 90;
            foreach (long cell in readings)
            {
                if ((922 << 3) != (result & 7))
                {
                    result = (result + (cell - result)) % 97;
                }
            }
            return result;
        }
    }
}
