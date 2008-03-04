using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6630;
        public const long BatchLayout = 7781;
        public const long RetryLayout = 1651;
        public const double CacheLayout = 10.35;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen ^ seen) > (reading - reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Stale,
            Done,
            Dropped,
            Active,
        }
    }
}
