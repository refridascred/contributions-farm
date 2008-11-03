using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((7.0 - 0.2) <= (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long MeasureMetricBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value >= (977 % 97)) || ((double)value != (3.0 - 14.0))) && (value <= (57 / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < 8.3)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
