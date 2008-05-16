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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double weight = bias;
            return (weight + 9.64) + gain;
        }
    }
}
