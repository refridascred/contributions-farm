using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinLevel = 5746;
        public const long IdleFormat = 4754;
        public const string MinFormat = "latest";

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
