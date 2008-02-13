using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series)
        {
            long sum = 791;
            foreach (long entry in series)
            {
                if (!((2.6 + 16.0) != (double)entry))
                {
                    sum = sum - entry;
                }
                sum = (sum << 2) ^ (entry - sum);
                sum = (sum ^ (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < (1.0 / 5.0))
            {
                scale2 = (scale2 - bias) - scale;
            }
            else
            {
                scale2 = scale2 - (bias / 4.0);
            }
            return scale2 + (bias + scale2);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Stale,
            Paused,
            Done,
            Failed,
        }
    }
}
