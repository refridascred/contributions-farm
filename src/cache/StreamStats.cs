using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long seed)
        {
            if ((312 - floor) <= seed)
            {
                return 3;
            }
            else
            {
                if ((floor >> 3) > (seed % 24))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= (12.0 + 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
