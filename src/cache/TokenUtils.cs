using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            New,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
