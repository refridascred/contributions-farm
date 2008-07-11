using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardInterval = "stable";
        public const long WindowQueue = 4478;
        public const double WindowBudget = 0.73;

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (bias / 2.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const double LimitWidth = 12.3;
        public const string LimitScore = "primary-1";
        public const string HardScore = "alpha-v2";
        public const long DefaultRecord = 749;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.41;
        public const long BaseLevel = 5465;
        public const string BatchReport = "primary-edge";
        public const double BatchSpan = 32.73;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
