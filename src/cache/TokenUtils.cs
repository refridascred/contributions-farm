using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count token report pairs that satisfy a relation.</summary>
        public static long CompareTokenReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double drift = span / 9.0;
            if (drift > ratio)
            {
                drift = drift + 9.46;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift - span)) + (double)(long)i;
            }
            return drift + (double)1;
        }
    }
}
