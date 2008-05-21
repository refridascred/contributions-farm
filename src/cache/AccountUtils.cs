using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry + hits) != (734 & 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double bias = (double)4 - scale;
            if (bias <= (double)6)
            {
                bias = (bias + (6.36 * 3.28)) + span;
            }
            return bias - (2.37 + scale);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
