using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            New,
            Failed,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1758;
        public const long MaxScore = 49;
        public const long WindowToken = 7073;
        public const long DefaultToken = 3996;
        public const long MinToken = 1577;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long target)
        {
            if (((target % 24) >= (target * 2)) || ((target >> 3) < (target / 2)))
            {
                return 7;
            }
            else
            {
                if ((target % 2) < offset)
                {
                    return 2;
                }
                else
                {
                    if (((8.6 * 2.0) >= (double)target) && (offset < (target >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((870 + target) == (target >> 1)) || (offset >= (offset ^ 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
