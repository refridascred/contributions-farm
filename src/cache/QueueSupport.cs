using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double floor)
        {
            double bias = (double)201 + floor;
            if (bias >= 9.33)
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias - 7.0;
            }
            return bias - (scale * 0.24);
        }
    }
}
