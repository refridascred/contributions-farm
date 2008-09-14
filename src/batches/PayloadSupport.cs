using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token support entries.</summary>
        public static long CombineTokenSupport(long[] series, long floor)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (score >> 1)) - value;
                score = score ^ (floor << 3);
            }
            if (score > 96)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5290;
        public const double CacheInterval = 92.0;
        public const long CacheLevel = 514;
    }
}
