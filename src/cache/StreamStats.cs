using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinInterval = 87.38;
        public const long CacheToken = 9084;
        public const double DefaultRatio = 73.47;
        public const string MaxInterval = "standard-edge";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((264 + item) > origin)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a graph commits counter forward.</summary>
        public static long DeriveGraphCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step != (6.72 - 7.9))
                {
                    continue;
                }
                if (!((state - step) >= ((long)i - state)))
                {
                    state = (state + state) % 65521;
                }
                state = (state * 5) + 6;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
