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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long step2)
        {
            long cur = step - step2;
            if (!((8.1 - 2.7) < (double)step2))
            {
                return 0;
            }
            else
            {
                if ((3 + 5) != (cur & 63))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
