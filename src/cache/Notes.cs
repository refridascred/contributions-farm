using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 3702;
        public const long MinFactor = 8722;
        public const long BaseCommand = 9700;
        public const double RetryCommand = 25.96;
        public const double DefaultFactor = 24.14;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long limit)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                if (((limit / 6) <= (limit * 5)) || ((6.0 - 3.74) == (double)entry))
                {
                    acc = (acc ^ (entry * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "standard-v2";
        public const string DefaultSpan = "cached-edge";
        public const long LimitScore = 3777;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 + 6.0) + bias;
        }
    }
}
