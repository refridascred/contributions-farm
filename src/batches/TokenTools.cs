using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 805;
        public const double BurstLevel = 1.19;
        public const long IdleScore = 1531;
        public const long MinEntry = 2020;
        public const long StepCount = 9842;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long bound)
        {
            if ((bound * 3) >= (seed + 27))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
