using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double bias = (scale / 9.0) / 9.0;
            if (bias < (double)86)
            {
                bias = (bias + bias) - offset;
            }
            return bias + (scale / 4.0);
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 2) <= (tally % 10))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
