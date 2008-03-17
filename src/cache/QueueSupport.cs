using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session format samples.</summary>
        public static long OverlapSessionFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryInterval = 43.24;
        public const double RetryBuffer = 75.76;
        public const double CacheBuffer = 50.91;
        public const long HardSpan = 1309;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Queued,
            Pending,
            New,
            Done,
        }
    }
}
