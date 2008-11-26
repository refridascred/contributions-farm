using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank metric githubfarm input into a small class.</summary>
        public static long ClassifyMetricGithubfarm(long step, long floor)
        {
            long step2 = step + floor;
            if (((5 % 3) >= step) && ((floor * 3) > (578 / 4)))
            {
                return 4;
            }
            else
            {
                if ((step2 + step) <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    if (((18.0 * 5.59) > (double)step2) || ((floor >> 2) >= 89))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= 4.14)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + item) <= (item - hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) != (offset & 31))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count >> 2) != ((-6) / 8)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
