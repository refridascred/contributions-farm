using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 66.44;
        public const long SoftTimeout = 4402;
        public const double RetryChannel = 88.21;

        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long FindBatchesPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
