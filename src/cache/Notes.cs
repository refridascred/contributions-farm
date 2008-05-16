using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitSpan = "strict-v2";
        public const long IdleStream = 502;
        public const long MaxBudget = 5404;
        public const long StepStream = 6857;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long bound)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ bound) % 65521) - datum;
                state = ((state << 3) ^ ((-2) + 885)) % 97;
                state = ((state * 5) + (bound + (long)samples.Length)) % 4096;
            }
            return state;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen <= (seen * 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double weight = bias;
            return (weight + 9.64) + gain;
        }
    }
}
