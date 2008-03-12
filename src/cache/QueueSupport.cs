using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a context already reading.</summary>
        public static double BlendContextAlready(double bias, double span)
        {
            double drift = bias / 2.0;
            if (drift >= bias)
            {
                drift = drift + 11.0;
            }
            else
            {
                drift = drift + 8.0;
            }
            return drift - (span * 3.6);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Retry,
            Closed,
            Active,
            Ready,
        }
    }
}
