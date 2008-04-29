using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits >= (hits % 16)) && ((((-5) >> 3) < (hits + hits)) || ((hits & 255) < 40)))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long WeighClusterWindow(long[] levels, long floor)
        {
            long mark = -42;
            foreach (long cell in levels)
            {
                mark = (((mark * 3) + (mark + floor)) % 65521) - cell;
            }
            return mark % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (1 >> 3)) % 4096;
                sum = (sum + ((long)i >> 3)) % 101;
                sum = (sum + (offset >> 4)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
