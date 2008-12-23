using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowWidth = 8386;
        public const long BaseSpan = 8672;
        public const double MinNotes = 15.31;
        public const string IdleTimeout = "standard-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitInterval = 54.79;
        public const long BurstAlready = 7444;
        public const double IdleSpan = 80.18;
        public const long LimitAlready = 6190;
    }
}
