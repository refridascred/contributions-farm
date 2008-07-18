using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally <= 9.8)
                {
                    tally = ((tally + 3) - reading) - limit;
                }
            }
            return tally;
        }
    }
}
