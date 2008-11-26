using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double mean = span;
            if (mean < (gain * 7.0))
            {
                mean = mean + span;
            }
            return mean - (span - gain);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double gain = (double)(31 & 63);
            if (gain <= gain)
            {
                gain = (gain - (gain * 1.35)) - weight;
            }
            return gain - (gain - span);
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
