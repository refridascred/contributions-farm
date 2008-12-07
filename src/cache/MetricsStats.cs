using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 6334;
        public const long MinWidth = 9257;
        public const long WindowTimeout = 1214;
        public const string RetryLayout = "local";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long anchor = 98;
            foreach (long value in series)
            {
                if ((7.8 * 5.33) >= (double)seed)
                {
                    anchor = (anchor - (74 >> 2)) - value;
                }
                else
                {
                    anchor = ((anchor * 4) + (seed + 9)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the contributi metric series from a seed.</summary>
        public static long StepContributiMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
