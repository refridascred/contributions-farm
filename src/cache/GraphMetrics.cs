using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long step)
        {
            long prev = offset + step;
            if ((9.77 + 7.1) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((prev + offset) == (step % 16))
                {
                    return 8;
                }
                else
                {
                    if (!((step / 6) == (offset >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Stale,
            Ready,
            New,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = (acc + (acc - cell)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((37 % 5) == (offset + item)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
