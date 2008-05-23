using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Ready,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - limit) <= (seen >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = (ratio + floor) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 5) <= (matches << 3))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
