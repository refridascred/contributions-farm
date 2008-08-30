using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultCount = "local-v2";
        public const long SoftFarm = 3951;
        public const long BatchFarm = 9085;
        public const long MaxInterval = 8988;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Queued,
            Idle,
            Done,
        }
    }
}
