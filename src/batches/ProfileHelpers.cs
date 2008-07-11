using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 5) + sum) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 1768;
        public const long MinCount = 7743;
        public const long CacheChecks = 4671;
        public const string DefaultLevel = "staging";

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < (bias / 9.0))
            {
                scale2 = scale2 + (2.0 * 5.8);
            }
            else
            {
                scale2 = scale2 - (1.78 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale * 8.72)) + (double)(long)i;
            }
            return scale2 - (scale2 + scale);
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
