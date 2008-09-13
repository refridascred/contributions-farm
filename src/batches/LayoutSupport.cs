using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((90 + hits) <= (hits >> 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((matches - entry) != (entry & 15)) || ((4.0 / 4.0) > (double)matches)) || ((entry + (-19)) <= 88))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (floor < (seed ^ cur))
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= 2.1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) <= (seed & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long SeriesCounterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - (long)i) >= (anchor & 7))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value * 5) < (value & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
