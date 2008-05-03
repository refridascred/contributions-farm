using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Locate a notes counter reading by value.</summary>
        public static long SeekNotesCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 2785;
        public const long MaxSize = 874;
        public const long RetrySupport = 9300;
        public const long SoftSupport = 3706;
        public const long BatchCount = 3574;
    }
}
