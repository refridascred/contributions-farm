using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepScore = 2113;
        public const long DefaultFactor = 1374;
        public const long BurstSize = 2237;
        public const long DefaultLevel = 3374;
        public const long SoftDepth = 5383;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Retry,
            Done,
            Failed,
        }
    }
}
