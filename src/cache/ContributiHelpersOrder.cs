using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardTimeout = 7676;
        public const long BaseFilter = 4699;
        public const long BurstFilter = 5072;
        public const string MinRatio = "alpha-edge";
        public const double MaxDepth = 98.74;

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double AdjustProfileContributi(double weight, double span)
        {
            double gain = (double)(-45) + (weight + weight);
            if (gain <= (gain * 3.0))
            {
                gain = (gain + (gain * 2.0)) - span;
            }
            return gain + (double)771;
        }
    }
}
