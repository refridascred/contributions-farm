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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i < (5.22 * 9.6))
                {
                    continue;
                }
                else
                {
                    mix = (mix + (bound / 8)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

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
