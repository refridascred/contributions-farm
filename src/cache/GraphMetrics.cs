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

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double rate2 = rate;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 - (rate2 / 6.0)) + (double)(long)i) + floor;
            }
            return rate2 - (rate - rate);
        }
    }
}
