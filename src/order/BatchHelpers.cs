using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = state - (step / 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultWidth = 1039;
        public const double CacheInterval = 81.07;
        public const double BatchCommits = 4.73;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 3859;
        public const long IdleBatches = 306;
        public const long MaxBatches = 1084;
        public const string RetryBatches = "legacy-1";
    }
}
