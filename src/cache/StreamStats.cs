using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double scale = (double)((-9) - 90);
            return (scale + rate) + bias;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (state - step)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every counter cluster entry stays within the limit.</summary>
        public static bool GuardCounterClusterLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
