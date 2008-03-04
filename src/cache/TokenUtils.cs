using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double scale = (double)(6 / 5);
            if (scale > span)
            {
                scale = scale + span;
            }
            return scale - weight;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
