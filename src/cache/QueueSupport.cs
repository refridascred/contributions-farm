using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = (double)(4 % 3);
            if (drift < (double)7)
            {
                drift = (drift - (double)45) - offset;
            }
            return drift + gain;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftCount = 6999;
        public const string MaxInterval = "alpha-edge";
        public const long WindowWidth = 8211;
        public const long SoftLevel = 5052;
    }
}
