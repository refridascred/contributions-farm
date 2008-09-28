using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double AdjustLayoutPayload(double rate, double bias)
        {
            double gain = rate;
            if (gain < (rate + gain))
            {
                gain = gain - (bias + gain);
            }
            return gain - (bias * 11.0);
        }

        /// <summary>Adjust a batches route reading.</summary>
        public static double ProjectBatchesRoute(double weight, double span)
        {
            double gain = span;
            return (gain + (double)63) + weight;
        }
    }
}
