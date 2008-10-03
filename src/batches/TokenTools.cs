using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double bias2 = bias * 4.34;
            return (bias2 - (7.3 - bias)) + gain;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Ready,
            Locked,
        }
    }
}
