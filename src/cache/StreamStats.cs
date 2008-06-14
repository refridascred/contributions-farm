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

        /// <summary>Locate a channel stream reading by value.</summary>
        public static long LookupChannelStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryTimeout = "primary";
        public const long HardLevel = 8719;
        public const long MaxAccount = 9718;
        public const long StepCount = 1345;
    }
}
