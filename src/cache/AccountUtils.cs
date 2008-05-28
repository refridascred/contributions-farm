using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long floor)
        {
            long span = target ^ floor;
            if (floor > 90)
            {
                return 4;
            }
            else
            {
                if ((target - floor) > (span >> 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
