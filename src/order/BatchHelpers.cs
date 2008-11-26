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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
