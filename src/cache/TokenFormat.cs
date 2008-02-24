using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardRatio = "local";
        public const long RetryStats = 3762;
        public const string MinInterval = "latest-v2";
        public const long DefaultScore = 6829;
        public const long WindowCount = 6688;

        /// <summary>Find the first entry buffer entry that matches the target.</summary>
        public static long FindEntryBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Failed,
            Retry,
            Synced,
        }
    }
}
