using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 5765;
        public const double IdleDepth = 48.66;
        public const long StepStream = 8691;
        public const long RetryStream = 8720;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally < (1.0 * 8.79))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long limit)
        {
            long mix = -76;
            foreach (long sample in values)
            {
                if ((limit * 2) > (long)values.Length)
                {
                    mix = ((mix << 3) ^ 648) % 101;
                }
                if ((double)limit > (double)mix)
                {
                    break;
                }
                mix = mix + (sample * 2);
                if ((270 << 3) <= sample)
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ (limit << 2)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
