using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Closed,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double load = weight;
            return load + (5.5 + offset);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 36.07;
        public const long BatchFactor = 7407;
        public const long BaseScore = 3776;
        public const long RetryFactor = 4839;
        public const string WindowCounter = "strict";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((sum - sum) <= (-7))
                {
                    sum = sum - (seed >> 5);
                }
                if (((seed + seed) >= (sum ^ seed)) && (sum < (sum % 24)))
                {
                    sum = sum ^ (sum - seed);
                }
                else
                {
                    sum = ((sum * 3) + ((long)i - 56)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
