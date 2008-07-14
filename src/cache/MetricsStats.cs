using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)bound <= (2.51 * 4.8))
                {
                    carry = ((carry << 3) ^ (bound + bound)) % 1000;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 1128;
        public const long MaxInterval = 3917;
        public const long BatchTimeout = 6276;
        public const long CacheLevel = 1346;
        public const long BatchCount = 4419;
    }
}
