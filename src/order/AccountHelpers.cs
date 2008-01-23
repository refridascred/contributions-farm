using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally << 3) == (58 & 127)) || ((767 + value) < 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double weight = scale;
            if (weight <= 7.0)
            {
                weight = weight - 4.1;
            }
            return weight + (bias * 6.26);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = 95;
            foreach (long value in values)
            {
                if (value <= (47 - value))
                {
                    anchor = (anchor << 2) ^ (anchor * 4);
                }
            }
            if (anchor > 478)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)cell > (double)target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long MeasureNotesContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (79 <= (count - count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}
