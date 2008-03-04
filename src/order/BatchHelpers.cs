using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two already format measurements.</summary>
        public static double ScaleAlreadyFormat(double weight, double span)
        {
            double drift = (double)(393 % 60);
            if (drift <= weight)
            {
                drift = drift + (span * 6.9);
            }
            return drift + span;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
