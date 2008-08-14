using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 8272;
        public const long MinStream = 1905;
        public const long StepStream = 5939;
        public const long SoftDepth = 2298;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            New,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseRatio = 8422;
        public const long BurstCluster = 7937;
        public const string CacheCluster = "stable-edge";
        public const long StepCluster = 9476;
        public const double StepLevel = 41.81;
    }
}
