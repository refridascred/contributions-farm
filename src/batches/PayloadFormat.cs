using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double bias)
        {
            double mean = bias / 7.0;
            if (mean < (bias + ratio))
            {
                mean = mean - 0.6;
            }
            return mean - (mean + mean);
        }

        /// <summary>Validate queue account readings against a bound.</summary>
        public static bool GuardQueueAccountLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (state < (state + state))
                {
                    state = (state - state) + reading;
                }
                if ((state - state) <= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
