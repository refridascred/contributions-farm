using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + span) - bias;
            }
            else
            {
                drift = drift - 2.6;
            }
            return drift - span;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 5474;
        public const string WindowChannel = "local";
        public const long HardChannel = 2614;
        public const long MaxChannel = 4752;
        public const string RetryCount = "open";
    }
}
