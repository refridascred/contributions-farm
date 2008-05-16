using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double weight = (double)75 - (bias - 7.5);
            if (weight > (weight + weight))
            {
                weight = (weight + (bias / 3.0)) - span;
            }
            return weight - (double)94;
        }
    }
}
