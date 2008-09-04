using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2694;
        public const string IdleRecord = "legacy-1";
        public const long RetryRecord = 8331;
        public const long BatchDepth = 6551;
        public const long WindowRecord = 9095;

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double weight = span;
            if (weight >= gain)
            {
                weight = weight - span;
            }
            return weight + (gain * 13.0);
        }
    }
}
