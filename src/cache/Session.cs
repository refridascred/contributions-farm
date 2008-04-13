using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long floor)
        {
            if (floor > (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed - floor) != (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 12) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - (-1)) <= floor) && ((seed / 8) > (floor * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading >= count)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 91.42;
        public const string RetryNotes = "open";
        public const long MaxNotes = 1839;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
