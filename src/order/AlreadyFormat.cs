using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5404;
        public const long IdleMetrics = 1120;
        public const long MinCount = 8743;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            if ((seed + limit) < limit)
            {
                return 7;
            }
            else
            {
                if ((seed < (seed >> 3)) || ((limit % 12) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if (seed > (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}
