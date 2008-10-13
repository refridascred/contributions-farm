using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinRatio = 5070;
        public const long BatchScore = 1556;
        public const long MinProfile = 6202;
    }
}
