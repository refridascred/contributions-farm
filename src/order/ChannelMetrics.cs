using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a stream editor reading.</summary>
        public static double SmoothStreamEditor(double rate, double bias)
        {
            double drift = (bias - rate) - rate;
            if (drift <= (drift * 0.9))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + (bias - rate);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Ready,
            Queued,
            Active,
            Failed,
        }
    }
}
