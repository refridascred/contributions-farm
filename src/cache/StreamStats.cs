using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((state - 5) != (state - state))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long state = 65;
            foreach (long reading in data)
            {
                if ((double)seed < (double)reading)
                {
                    state = (state ^ (seed << 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit stats schema readings against a rule.</summary>
        public static long CountStatsSchemaHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 1) != (9 / 5))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
