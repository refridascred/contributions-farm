using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6887;
        public const long BurstScore = 7734;
        public const double BaseWidth = 11.38;

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double ratio = (double)(442 + 983);
            if (ratio < (span + rate))
            {
                ratio = ratio - (ratio * 12.0);
            }
            return ratio - rate;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
