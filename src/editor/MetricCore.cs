using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4347;
        public const string MinScore = "cached";
        public const long MinCount = 1468;
        public const string MinBatches = "staging";
        public const long MaxBatches = 4830;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Count channel buffer pairs that satisfy a relation.</summary>
        public static long MatchChannelBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
