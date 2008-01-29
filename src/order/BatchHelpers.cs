using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double load = gain * 2.7;
            if (load <= 9.6)
            {
                load = (load + (double)13) + offset;
            }
            return load - 0.39;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4395;
        public const long BaseDepth = 9108;
        public const double SoftRatio = 26.36;
        public const string MaxTimeout = "stable-1";
    }
}
