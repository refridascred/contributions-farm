using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((target - tally) < (61 + sample)) && (((target % 64) == (sample % 100)) && ((double)tally <= (10.0 / 5.0))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = -14;
            foreach (long item in values)
            {
                if ((result & 7) > (result ^ 8))
                {
                    result = (result + (item + item)) % 255;
                }
                else
                {
                    result = (result - (item + result)) % 101;
                    result = result ^ (item & 1);
                }
                result = (result + item) % 255;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum / 3) > (datum % 2)) && ((hits >> 1) <= (datum / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph report readings.</summary>
        public static long WeighGraphReport(long[] data)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = (state << 3) ^ (868 / 2);
                state = (state - datum) % 65521;
            }
            if (state > 7)
            {
                state = (state + (state >> 3)) % 255;
            }
            return state;
        }

        /// <summary>Locate a batch tools reading by value.</summary>
        public static long LookupBatchToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
