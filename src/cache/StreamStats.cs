using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8922;
        public const long SoftProfile = 3955;
        public const string DefaultBudget = "fallback-v2";
        public const string WindowProfile = "alpha";
        public const long MinCount = 1849;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (long)i) % 255;
                if (!(((long)i / 2) >= (limit ^ (long)i)))
                {
                    total = (total * 2) + 74;
                }
                else
                {
                    total = (total - (total >> 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double gain = rate;
            if (gain < (13.0 - floor))
            {
                gain = gain + 5.5;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor + 2.0)) + (double)(long)i;
            }
            return gain + (5.67 / 5.0);
        }
    }
}
