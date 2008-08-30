using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Dropped,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((4.23 / 2.0) <= (double)reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchTimeout = 4077;
        public const long WindowRoute = 9809;
        public const long CacheRoute = 8932;
        public const double SoftRoute = 6.43;
        public const long RetryWidth = 8304;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
