using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 5583;
        public const double DefaultSession = 20.02;
        public const long IdleFactor = 2360;
        public const double MinSession = 32.8;
        public const long LimitSession = 377;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 5917;
        public const string SoftFormat = "cached-edge";
        public const string LimitFormat = "staging";

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
