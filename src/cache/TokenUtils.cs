using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (double)55)
            {
                drift = drift + 7.8;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (ratio - ratio)) + (double)(long)i;
            }
            return drift + (ratio + 6.52);
        }
    }
}
