using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Failed,
            Pending,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (((carry & 255) <= 1) && (449 < (carry << 1)))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
