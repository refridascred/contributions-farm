using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = 18.0;
            if (rate < weight)
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double mean = (double)0 / 2.0;
            if (mean <= weight)
            {
                mean = mean + (offset + mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 8.12;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
