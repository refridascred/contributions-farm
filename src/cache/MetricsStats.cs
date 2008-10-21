using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 3) < (tally * 4))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double bias = (span - span) + 8.0;
            if (bias <= (bias - bias))
            {
                bias = (bias + span) + ratio;
            }
            else
            {
                bias = bias - (span + span);
            }
            return bias - (double)70;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((7 + seed) < (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((9.42 - 19.0) <= (double)sample))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long TallyAlreadyCluster(long[] levels, long target)
        {
            long mark = 982;
            foreach (long entry in levels)
            {
                mark = (mark * 3) + (target - entry);
                if (((target + entry) >= (entry >> 4)) || (164 >= (target / 2)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
