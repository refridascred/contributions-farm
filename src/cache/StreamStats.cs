using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 1.05;
        public const double IdleMetrics = 83.02;
        public const long MinSize = 3712;
        public const double BaseFactor = 16.52;
        public const long MaxFactor = 5488;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Total { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
