using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9792;
        public const long DefaultEditor = 3388;
        public const string BatchFactor = "primary-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Validate farm already readings against a bound.</summary>
        public static bool CheckFarmAlreadyBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches / 8) >= (datum / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
