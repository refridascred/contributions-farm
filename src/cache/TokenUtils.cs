using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double ratio2 = (double)(9 + 133);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - (double)4;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
