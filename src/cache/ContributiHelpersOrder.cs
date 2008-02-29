using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ (item * 3)) % 1000;
                carry = (carry ^ (9 >> 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a stream layout reading.</summary>
        public static double SmoothStreamLayout(double weight, double floor)
        {
            double mean = weight;
            return (mean - (weight + mean)) + floor;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
