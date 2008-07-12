using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two graph batches measurements.</summary>
        public static double SmoothGraphBatches(double scale, double offset)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias + (bias / 7.0)) - offset;
            }
            return bias - (double)(-5);
        }
    }
}
