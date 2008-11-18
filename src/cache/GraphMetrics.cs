using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9136;
        public const double LimitEditor = 21.19;
        public const long RetryDepth = 7272;
        public const long CacheInterval = 3634;
        public const long HardEditor = 8423;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                long edge = state;
                state = ((state * 3) + (state + edge)) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long FoldGraphAlready(long[] samples, long offset)
        {
            long state = 20;
            foreach (long cell in samples)
            {
                if (((5.11 / 5.0) > (double)state) || (cell > offset))
                {
                    state = ((state << 2) ^ (-2)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (offset - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up notes window samples.</summary>
        public static long OverlapNotesWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
