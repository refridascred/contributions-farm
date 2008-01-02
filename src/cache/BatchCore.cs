using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)seen <= (20.0 + 4.0)) || ((bound + bound) < (value + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long DeriveClusterWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                long seen = bound + bound;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - (seen / 9)) + (long)i2;
                }
                if (seen >= (anchor / 9))
                {
                    anchor = anchor ^ (242 - (long)i);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
