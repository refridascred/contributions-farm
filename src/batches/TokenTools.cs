using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double ratio = (gain + span) * 6.5;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 1411;
        public const long SoftChannel = 4867;
        public const double HardChannel = 33.72;
        public const double IdleChannel = 49.35;
        public const double MaxDepth = 18.72;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
