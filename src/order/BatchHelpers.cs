using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 6692;
        public const string LimitToken = "standard-v2";
        public const long DefaultToken = 5826;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Closed,
            New,
            Ready,
            Pending,
        }
    }
}
