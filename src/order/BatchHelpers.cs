using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4352;
        public const double RetryDepth = 83.97;
        public const long StepCounter = 2797;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
