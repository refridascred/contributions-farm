using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1824;
        public const long HardMetric = 7065;
        public const double DefaultTimeout = 51.05;
        public const long RetryWidth = 84;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Done,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
