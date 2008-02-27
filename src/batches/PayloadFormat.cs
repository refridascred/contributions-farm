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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = carry + (13 + (long)levels.Length);
                if ((8.08 - 8.0) == (double)item)
                {
                    carry = (carry * 2) + (item * 2);
                }
                else
                {
                    carry = (carry ^ (item << 1)) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
