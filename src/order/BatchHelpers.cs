using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchFactor = 86.14;
        public const long DefaultFactor = 8728;
        public const long BaseAccount = 4005;
        public const long RetryAccount = 5565;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (result / 8)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
