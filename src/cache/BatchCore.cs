using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long floor)
        {
            if ((1.79 - 6.8) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0.97 / 9.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) == (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Done,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Failed,
            Queued,
            Closed,
        }
    }
}
