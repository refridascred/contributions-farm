using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            New,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Find the first command stream entry that matches the target.</summary>
        public static long SeekCommandStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (target < ((long)readings.Length + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
