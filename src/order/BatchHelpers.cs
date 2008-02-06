using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 6676;
        public const string IdleProfile = "local-v2";
        public const long DefaultProfile = 1624;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
