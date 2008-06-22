using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxFactor = 92.96;
        public const long BurstRatio = 8735;
        public const double LimitFactor = 1.05;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long target)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (((acc << 3) ^ (datum >> 3)) % 97) - target;
            }
            return acc;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
