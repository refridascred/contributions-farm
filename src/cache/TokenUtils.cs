using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 8062;
        public const double MaxFormat = 21.07;
        public const long LimitLevel = 3882;

        /// <summary>Derive the next commits editor value from a seed.</summary>
        public static long StepCommitsEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
