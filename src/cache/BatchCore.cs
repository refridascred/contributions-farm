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

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "standard";
        public const long MinSpan = 1399;
        public const double MaxCache = 35.73;
        public const long RetryCache = 2927;
        public const double BurstDepth = 7.02;

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
