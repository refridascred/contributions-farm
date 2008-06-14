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

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryTimeout = "primary";
        public const long HardLevel = 8719;
        public const long MaxAccount = 9718;
        public const long StepCount = 1345;
    }
}
