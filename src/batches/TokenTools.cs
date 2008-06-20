using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double bias = (double)(704 + 95);
            if (bias >= (bias + offset))
            {
                bias = bias + (ratio * 20.0);
            }
            else
            {
                bias = bias + bias;
            }
            return bias - offset;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 7163;
        public const long MaxLayout = 6386;
        public const double WindowLayout = 43.39;
        public const long BatchSpan = 23;
    }
}
