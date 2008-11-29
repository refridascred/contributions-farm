using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseWidth = 34.82;
        public const long MaxAlready = 3693;
        public const long StepAlready = 1991;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (step & 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
