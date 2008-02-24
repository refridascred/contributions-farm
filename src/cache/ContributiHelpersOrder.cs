using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long target)
        {
            if ((double)origin <= (5.0 + 8.8))
            {
                return 2;
            }
            else
            {
                if (((origin / 6) <= origin) && (origin > (target / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((42 ^ target) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - hits) == (hits % 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
