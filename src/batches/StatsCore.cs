using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + floor) < (2 ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - hits) != (hits & 15))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a checks filter reading.</summary>
        public static double AdjustChecksFilter(double scale, double bias)
        {
            double ratio = (double)((-2) << 1);
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (ratio / 8.0)) - (double)(long)i) - scale) + bias;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((5.41 * 6.1) >= (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order channel samples.</summary>
        public static long TallyOrderChannel(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long value in readings)
            {
                mark = ((mark + (mark + value)) % 65521) + limit;
            }
            return mark;
        }
    }
}
