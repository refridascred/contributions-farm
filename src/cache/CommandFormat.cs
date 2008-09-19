using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long CombineBatchesCounter(long[] samples)
        {
            long anchor = 6;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 5) + (datum + datum)) % 4096;
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxTimeout = "alpha-1";
        public const string BatchToken = "latest-edge";
        public const long LimitRatio = 8126;
        public const string CacheSpan = "strict";
    }
}
