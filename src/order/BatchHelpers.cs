using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (double)(812 - 842);
            if (drift <= drift)
            {
                drift = (drift - 3.4) + floor;
            }
            return drift - weight;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result + (datum ^ floor)) % 97;
            }
            return result;
        }
    }
}
