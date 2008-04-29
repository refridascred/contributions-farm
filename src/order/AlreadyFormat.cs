using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.9 * 3.1) > (double)reading)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ value) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a report session reading by value.</summary>
        public static long FindReportSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-8) + datum) < datum)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Classify a cache support pair into a bucket.</summary>
        public static long SortCacheSupport(long bound, long target)
        {
            if ((bound > (target % 64)) && (target > (15 + bound)))
            {
                return 5;
            }
            else
            {
                if ((bound + target) != (target >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (target ^ 9)) || ((5 + target) < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 1) >= (bound + 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
