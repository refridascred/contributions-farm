using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 9099;
        public const long MaxWindow = 1643;
        public const long HardDepth = 8092;
        public const double DefaultWidth = 58.88;

        /// <summary>Scale a githubfarm token figure with a bias.</summary>
        public static double ProjectGithubfarmToken(double rate, double bias)
        {
            double weight = bias + (rate / 9.0);
            if (weight <= bias)
            {
                weight = weight + (double)90;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)8;
        }
    }
}
