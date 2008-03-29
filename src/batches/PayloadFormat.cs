using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double load = span * 7.4;
            if (load < (scale - load))
            {
                load = load + 8.2;
            }
            return load + (span * 1.85);
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = 6.0 - (double)2;
            if (rate2 >= (double)2)
            {
                rate2 = (rate2 + offset) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 0.9;
        }
    }
}
