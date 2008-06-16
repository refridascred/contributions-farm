using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = 8.58;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - rate) - (double)(long)i) + span;
            }
            return load + 4.91;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double rate = floor;
            if (rate > (floor + 7.0))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
