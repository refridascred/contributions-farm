using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "latest";
        public const long IdleDepth = 3282;
        public const double RetryScore = 84.94;
        public const double BaseBuffer = 22.29;
        public const long CacheBuffer = 5104;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
