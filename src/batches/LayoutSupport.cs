using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3879;
        public const long HardChecks = 8310;
        public const long DefaultCount = 3589;
        public const long SoftChecks = 5788;

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)8)
            {
                load = (load - 5.11) - bias;
            }
            return load - scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const string BatchStream = "stable-v2";
        public const long SoftStream = 2509;
        public const long HardSpan = 3577;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRatio = 2966;
        public const long BatchDepth = 3722;
        public const double LimitRoute = 33.42;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
