using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (989 >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long BaseSize = 6658;
        public const long RetryTimeout = 6976;
        public const string BurstEntry = "alpha-edge";
        public const long LimitEntry = 5548;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Closed,
            Queued,
            Paused,
        }
    }
}
