using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + count) < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5867;
        public const long RetryCommits = 3830;
        public const long WindowCommits = 812;
        public const long CacheWidth = 3051;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Draft,
            Failed,
            Active,
        }
    }
}
