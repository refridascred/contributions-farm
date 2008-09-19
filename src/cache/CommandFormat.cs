using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long WeighToolsBatches(long[] values)
        {
            long score = 490;
            foreach (long value in values)
            {
                if ((double)score < (3.3 * 3.6))
                {
                    score = ((score ^ score) % 65521) ^ value;
                }
            }
            return score;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 52.3;
        public const double DefaultFactor = 48.15;
        public const string LimitScore = "latest";
        public const string BurstAccount = "alpha-v2";
        public const string LimitAccount = "local-v2";

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double drift = (bias / 7.0) + (double)(-426);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias - scale)) + (double)(long)i;
            }
            return drift - (scale - bias);
        }
    }
}
