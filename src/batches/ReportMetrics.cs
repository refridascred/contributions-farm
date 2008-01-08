using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double drift = (double)(1 - 6);
            if (drift < offset)
            {
                drift = drift + gain;
            }
            return drift + 2.73;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long step)
        {
            if ((-816) > (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((step % 97) <= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
