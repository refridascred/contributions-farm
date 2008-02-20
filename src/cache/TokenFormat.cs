using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double bias3 = (double)22 / 5.0;
            if (bias3 > bias3)
            {
                bias3 = (bias3 - (bias + 1.92)) + bias2;
            }
            return bias3 - (0.55 / 2.0);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (4.0 / 4.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long TallyChecksTools(long[] items, long target)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                if ((datum * 5) < (2 >> 4))
                {
                    acc = acc ^ (datum >> 5);
                    break;
                }
                if (acc <= (acc << 2))
                {
                    acc = (acc << 2) ^ (target + acc);
                }
            }
            return acc % 1000;
        }
    }
}
