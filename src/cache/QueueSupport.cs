using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Find the first profile already entry that matches the target.</summary>
        public static long FindProfileAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
