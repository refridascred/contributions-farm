using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double drift = ratio - (ratio / 4.0);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(long)i) - span;
            }
            return drift + (ratio * 13.0);
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool GuardCounterCacheBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
