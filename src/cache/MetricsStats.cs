using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result - (offset * 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7094;
        public const long SoftGraph = 2864;
        public const long CacheGraph = 7658;
    }
}
