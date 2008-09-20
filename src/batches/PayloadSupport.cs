using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultWidth = "alpha-1";
        public const long BatchEditor = 5613;
        public const double MinEditor = 59.31;
        public const long LimitCount = 8442;

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (mean - bias))
            {
                mean = mean - (double)94;
            }
            return mean + scale;
        }
    }
}
