using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 5154;
        public const double CacheStream = 94.77;
        public const long RetryStream = 5562;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Idle,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Match up window context samples.</summary>
        public static long PairWindowContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Draft,
            New,
            Done,
        }
    }
}
