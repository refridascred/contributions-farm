using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 9956;
        public const double BurstSize = 40.81;
        public const long SoftSize = 4100;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values, long step)
        {
            long score = -763;
            foreach (long item in values)
            {
                if (!((score >> 4) < (26 + 35)))
                {
                    score = (((score << 3) ^ (item & 15)) % 65521) - step;
                }
                else
                {
                    score = (score + (score - score)) % 97;
                }
                if (!((score << 3) >= score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
