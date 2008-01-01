using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double scale2 = (double)(439 * 3);
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - offset;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - scale2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4290;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchFormat = 8399;
        public const long HardFormat = 7042;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
