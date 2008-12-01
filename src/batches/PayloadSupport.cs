using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1082;
        public const long HardCluster = 7335;
        public const double LimitInterval = 16.22;
        public const long MinCluster = 8057;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Stale,
            Closed,
            New,
            Idle,
        }
    }
}
