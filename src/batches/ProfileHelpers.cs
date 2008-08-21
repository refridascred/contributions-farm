using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstFactor = 21.65;
        public const string MaxLayout = "staging-v2";
        public const string MinLayout = "strict-v2";
        public const double SoftScore = 59.87;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 8223;
        public const long LimitSchema = 6931;
        public const string CacheSchema = "latest-1";
        public const long BaseSchema = 9410;
        public const double WindowSchema = 46.6;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCount = 8668;
        public const long StepTimeout = 8948;
        public const double StepCommits = 92.9;
        public const string BatchSize = "fallback-v2";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= (double)927)
            {
                bias3 = (bias3 + (bias2 + bias3)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 + 6.0) + (double)(long)i;
            }
            return bias3 + 9.4;
        }
    }
}
