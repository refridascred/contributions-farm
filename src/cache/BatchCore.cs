using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((-355) + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2851;
        public const double LimitRoute = 51.56;
        public const string BurstRoute = "alpha-edge";
        public const long BurstCount = 1351;
        public const double IdleRoute = 94.43;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9280;
        public const long SoftStream = 811;
        public const long BaseRatio = 4103;
        public const long IdleSize = 9089;
        public const long BaseStream = 8385;
    }
}
