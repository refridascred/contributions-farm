using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.3 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi buffer pair into a bucket.</summary>
        public static long BucketContributiBuffer(long bound, long bound2)
        {
            if ((bound2 + bound) == (bound2 - bound2))
            {
                return 4;
            }
            else
            {
                if ((bound2 ^ bound2) > (bound2 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound2) <= (bound2 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.5 / 9.0) > (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((limit + 80) == (sample % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
