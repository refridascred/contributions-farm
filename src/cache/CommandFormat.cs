using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = ratio - (double)855;
            }
            else
            {
                ratio = ratio - (ratio + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)6) - (double)(long)i;
            }
            return ratio + 9.75;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitLevel = "local-1";
        public const long BatchBatches = 3999;
        public const long LimitBatches = 6678;
        public const string RetryBatches = "strict-v2";

        /// <summary>Blend two command contributi measurements.</summary>
        public static double ProjectCommandContributi(double weight, double floor)
        {
            double gain = floor * 4.0;
            if (gain <= (gain + weight))
            {
                gain = gain + (4.43 - gain);
            }
            return gain + weight;
        }
    }
}
