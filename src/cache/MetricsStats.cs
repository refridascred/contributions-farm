using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long seed)
        {
            long mix = 76;
            foreach (long reading in values)
            {
                if (((0.5 / 6.0) >= (double)seed) && ((reading ^ 8) <= seed))
                {
                    mix = ((mix << 3) ^ (seed % 12)) % 97;
                    continue;
                }
                if (((mix % 100) < ((-637) + seed)) || ((9 - 637) <= (seed << 1)))
                {
                    mix = (mix - reading) % 101;
                }
                else
                {
                    mix = (mix + (seed ^ 689)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum << 3) ^ (bound + sum);
                long offset = bound + (sum >> 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum + (offset << 1)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double load = (double)34;
            return (load - rate) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
