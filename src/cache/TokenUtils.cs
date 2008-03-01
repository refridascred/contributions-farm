using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((6.0 / 6.0) >= (double)seed) && ((3.0 * 18.0) <= (double)datum)) || (seed >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = 9.0;
            return ((load + 2.51) + bias) + bias2;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
