using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command record figure with a bias.</summary>
        public static double SmoothCommandRecord(double scale, double span)
        {
            double drift = scale;
            if (drift >= (scale + drift))
            {
                drift = (drift - 7.42) + span;
            }
            return drift - 1.3;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Queued,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long origin)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if ((sample + state) <= 121)
                {
                    state = (state ^ (sample - origin)) % 255;
                }
            }
            return state;
        }
    }
}
