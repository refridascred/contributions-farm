using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double bias = (gain + span) - gain;
            return bias - bias;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((9.2 - 12.0) != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long origin, long step)
        {
            long gap = origin ^ step;
            if ((step >> 1) <= (gap / 4))
            {
                return 6;
            }
            else
            {
                if (origin > (origin >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
