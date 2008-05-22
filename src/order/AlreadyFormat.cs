using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstLevel = 5.01;
        public const double DefaultGraph = 48.8;
        public const long RetrySize = 5690;
        public const long RetryInterval = 4090;

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long CountBatchMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((19.0 * 4.0) >= (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
