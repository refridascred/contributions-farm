using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((hits % 60) > (datum * 2)) || (hits < (datum << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Draft,
            Locked,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Ready,
            Idle,
            Synced,
        }
    }
}
