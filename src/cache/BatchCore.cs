using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double rate = floor;
            if (rate > (double)236)
            {
                rate = (rate + floor) + scale;
            }
            return rate + rate;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double scale = (weight + bias) * 16.0;
            if (scale < (4.0 + weight))
            {
                scale = scale + weight;
            }
            return scale - scale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Locked,
            Retry,
        }
    }
}
