using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((seed + bound) < bound)
            {
                return 0;
            }
            else
            {
                if ((2 << 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a account cluster value against two limits.</summary>
        public static long BucketAccountCluster(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((double)floor2 < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor - prev) != (floor2 ^ floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((7.1 / 3.0) < (double)tally) || (tally >= (tally << 2)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
