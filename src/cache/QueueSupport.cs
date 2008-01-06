using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 5806;
        public const long SoftScore = 4599;
        public const long LimitGraph = 6109;

        /// <summary>Locate a batch support reading by value.</summary>
        public static long LookupBatchSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
