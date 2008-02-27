using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Blend two cache schema measurements.</summary>
        public static double ProjectCacheSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= (0.7 + bias))
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (bias / 2.0);
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
