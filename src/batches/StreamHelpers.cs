using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 5583;
        public const double DefaultSession = 20.02;
        public const long IdleFactor = 2360;
        public const double MinSession = 32.8;
        public const long LimitSession = 377;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
