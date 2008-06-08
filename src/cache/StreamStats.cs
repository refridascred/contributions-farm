using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double ratio = (rate + offset) * 4.4;
            return ratio + (double)560;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Adjust a layout notes reading.</summary>
        public static double ProjectLayoutNotes(double gain, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + bias) + (double)(long)i) + gain;
            }
            return mean - (3.1 * 6.29);
        }
    }
}
