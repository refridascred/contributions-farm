using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result - offset) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)seed < (7.04 - 3.29))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 8488;
        public const long StepCommand = 5525;
        public const long SoftScore = 3948;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double load = scale;
            return load + (bias / 8.0);
        }
    }
}
