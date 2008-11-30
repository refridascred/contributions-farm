using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long SortClusterLayout(long limit, long seed)
        {
            if ((seed / 6) >= (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if (((seed + limit) == (limit & 255)) || ((seed ^ seed) == (limit + seed)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4.0 + 4.85) > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
