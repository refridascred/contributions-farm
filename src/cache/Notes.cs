using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Queued,
            Paused,
        }

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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Retry,
            Ready,
            Locked,
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
