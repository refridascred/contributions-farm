using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long target)
        {
            long sum = 5;
            foreach (long value in readings)
            {
                sum = ((sum << 2) ^ (value % 2)) % 1000;
                sum = (sum ^ (value - target)) % 65521;
            }
            if (sum < 22)
            {
                sum = (sum * 4) + target;
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
