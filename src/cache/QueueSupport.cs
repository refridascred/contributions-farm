using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 89.69;
        public const long BurstSize = 854;
        public const long WindowSchema = 236;
        public const double RetryDepth = 25.69;
        public const long StepScore = 2741;
    }
}
