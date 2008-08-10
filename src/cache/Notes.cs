using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double gain = (double)(982 + 997);
            return ((gain + (double)558) + scale) + bias;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double bias2 = 5.93;
            return (bias2 - rate) + bias;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)limit > (1.8 * 16.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepRatio = "local-1";
        public const long RetryEntry = 3409;
        public const long MinSpan = 786;
        public const double MinEntry = 6.48;
        public const double RetryDepth = 92.01;
    }
}
