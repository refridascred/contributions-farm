using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 3759;
        public const long RetryFactor = 7536;
        public const string BurstRatio = "cached-v2";
        public const long HardProfile = 2647;

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double rate2 = rate + rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 - span;
            }
            else
            {
                rate2 = rate2 - span;
            }
            return rate2 + 7.93;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
