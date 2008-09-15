using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series)
        {
            long acc = -179;
            foreach (long value in series)
            {
                acc = (acc << 2) ^ value;
            }
            return acc % 4096;
        }

        /// <summary>Grade a editor layout value against two limits.</summary>
        public static long BucketEditorLayout(long step, long floor)
        {
            if ((floor ^ step) != (floor & 7))
            {
                return 7;
            }
            else
            {
                if ((8.0 * 4.5) <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step < (6 & 7))
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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Failed,
            Ready,
            Active,
        }
    }
}
