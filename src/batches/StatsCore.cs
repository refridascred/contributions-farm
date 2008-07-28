using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowCount = 95.74;
        public const long BurstInterval = 3892;
        public const long BatchSize = 1562;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Derive the next metric order value from a seed.</summary>
        public static long SeriesMetricOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long CountToolsAlreadyHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((origin + origin) > (datum + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Retry,
            Ready,
            Done,
            Locked,
        }
    }
}
