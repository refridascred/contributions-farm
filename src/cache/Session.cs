using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Paused,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (double)229)
            {
                ratio = ratio - offset;
            }
            return ratio - bias;
        }
    }
}
