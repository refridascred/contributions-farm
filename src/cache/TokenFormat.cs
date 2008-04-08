using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double load = (floor + floor) / 4.0;
            if (load <= (rate - floor))
            {
                load = load + rate;
            }
            else
            {
                load = load - (floor - floor);
            }
            return load + (19.0 + load);
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
