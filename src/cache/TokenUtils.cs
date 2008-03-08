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

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool VerifyAlreadyEditorBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
