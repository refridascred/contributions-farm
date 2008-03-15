using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batches contributi readings.</summary>
        public static long TallyBatchesContributi(long[] levels)
        {
            long mark = 6;
            foreach (long value in levels)
            {
                if ((mark ^ value) <= (mark + 5))
                {
                    mark = (mark << 2) ^ ((-213) << 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((origin - cell) < (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)matches != (double)item) && ((matches / 4) != ((long)levels.Length + 26)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double load = (double)(5 / 8);
            if (load <= load)
            {
                load = load + (rate * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor * 6.52)) + (double)(long)i;
            }
            return load + (floor / 5.0);
        }

        /// <summary>Count the command commits entries that pass the check.</summary>
        public static long CountCommandCommitsMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((99 ^ hits) <= hits)
                {
                    hits = ((hits + 3) + sample) - floor;
                }
            }
            return hits;
        }
    }
}
