using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double bias)
        {
            double ratio = 5.59;
            return ((ratio - (double)3) + rate) + bias;
        }
    }
}
