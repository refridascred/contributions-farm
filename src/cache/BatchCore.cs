using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2520;
        public const string DefaultFactor = "latest";
        public const long MaxContext = 1991;
        public const string RetryContext = "stable-v2";
        public const string CacheContext = "open";

        /// <summary>Match up batch order samples.</summary>
        public static long CompareBatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Dropped,
            Failed,
        }
    }
}
