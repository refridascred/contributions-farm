using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of profile editor entries.</summary>
        public static long CombineProfileEditor(long[] readings, long limit)
        {
            long sum = -137;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (sum << 1)) + item;
                if ((double)limit < 7.25)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)74)
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (bias2 - scale);
        }
    }
}
