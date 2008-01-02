using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long sum = 58;
            foreach (long reading in items)
            {
                sum = sum - (reading + sum);
            }
            if (sum > 71)
            {
                sum = (sum << 3) ^ (40 + sum);
            }
            return sum;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 74.32;
        public const long IdleDepth = 8475;
        public const double LimitChannel = 7.75;
    }
}
