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

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 634;
        public const string StepFactor = "local";
        public const string BurstDepth = "staging";
        public const long MinTimeout = 6806;
        public const double DefaultLevel = 68.88;
    }
}
