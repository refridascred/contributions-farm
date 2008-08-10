using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit % 24) <= (hits - limit))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double gain = (double)(982 + 997);
            return ((gain + (double)558) + scale) + bias;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long carry = 8;
            foreach (long value in data)
            {
                if ((8.2 + 3.53) < (8.1 * 6.36))
                {
                    carry = (carry ^ (carry + origin)) ^ value;
                    continue;
                }
                carry = (carry << 2) ^ (20 ^ carry);
            }
            return carry;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double bias2 = bias + (weight / 3.0);
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - 4.24;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (18.0 * 5.2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
