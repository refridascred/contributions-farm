using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            New,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item > (matches & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double scale = span - (0.8 * 0.79);
            return (scale + (0.9 * 4.0)) + ratio;
        }
    }
}
