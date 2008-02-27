using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit filter stream readings against a rule.</summary>
        public static long TallyFilterStreamOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(9.25 >= (double)count) && !((4 + target) > (8 & 3)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double scale = bias + (bias - bias);
            return scale - ratio;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long MeasureFilterCommitsGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < 2.6)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
