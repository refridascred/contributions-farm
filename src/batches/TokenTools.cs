using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "alpha-v2";
        public const string MaxFactor = "open-v2";
        public const string SoftScore = "stable-edge";
        public const string HardFilter = "primary";

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ (acc * 2)) % 65521) + entry) + seed;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9336;
        public const double StepBudget = 33.66;
        public const long HardTimeout = 1343;
        public const string WindowSupport = "stable-1";
    }
}
