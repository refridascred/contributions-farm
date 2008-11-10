using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 81;
            foreach (long value in values)
            {
                if (!(((long)values.Length / 8) <= carry))
                {
                    carry = ((carry ^ (carry * 4)) % 1000) ^ value;
                }
            }
            return carry;
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
