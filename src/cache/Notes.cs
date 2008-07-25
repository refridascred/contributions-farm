using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "staging-v2";
        public const string StepAlready = "alpha-v2";
        public const long CacheTimeout = 5359;
        public const long CacheAlready = 3153;
        public const long BaseScore = 666;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long score = 16;
            foreach (long entry in samples)
            {
                if ((entry + 746) == (5 << 2))
                {
                    score = (score + (score / 7)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Idle,
            Active,
        }
    }
}
