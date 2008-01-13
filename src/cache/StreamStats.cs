using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double load = (bias * 4.0) + rate;
            if (load > (3.51 * 6.13))
            {
                load = load - (rate - bias);
            }
            return load + (13.0 / 7.0);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double bias = weight;
            if (bias < (double)4)
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-84)) + (double)(long)i;
            }
            return bias + (weight * 3.4);
        }
    }
}
