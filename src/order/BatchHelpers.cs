using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 373;
        public const string BatchSize = "cached-v2";
        public const long StepScore = 1900;
        public const string SoftCount = "primary";
        public const long MinPayload = 5447;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 3875;
        public const long HardSpan = 8792;
        public const long MaxAccount = 1;
        public const long CacheBudget = 533;
    }
}
