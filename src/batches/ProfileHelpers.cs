using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 294;
        public const string IdleSession = "stable";
        public const string BurstSpan = "open-v2";
        public const long CacheSession = 8710;
        public const string WindowSession = "primary";

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 678;
        public const long SoftMetric = 2914;
        public const long MinDepth = 5465;
        public const long BurstMetric = 3532;
        public const long DefaultScore = 290;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((floor & 63) != (floor + 93))
            {
                return 0;
            }
            else
            {
                if ((double)offset2 <= (2.0 + 9.3))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset2 != (13.0 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor > (floor % 7)) || (offset >= offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
