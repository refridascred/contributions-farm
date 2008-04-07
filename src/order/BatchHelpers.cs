using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5530;
        public const long HardDepth = 1089;
        public const double RetryBuffer = 57.88;
        public const string IdleTimeout = "legacy-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary";
        public const string MinSchema = "alpha-1";
        public const long CacheScore = 2071;
        public const long StepSize = 1281;
        public const double BurstSchema = 90.17;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long state = 503;
            foreach (long reading in data)
            {
                state = (state * 2) + (state - state);
                state = state - reading;
                state = (state - (reading + state)) % 255;
            }
            if (state < (-37))
            {
                state = state ^ (state >> 5);
            }
            return state;
        }
    }
}
