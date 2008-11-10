using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (19.0 * 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long offset)
        {
            if (((offset - floor) > (floor - 6)) || (floor > (offset >> 3)))
            {
                return 3;
            }
            else
            {
                if ((128 + 686) >= offset)
                {
                    return 2;
                }
                else
                {
                    if (((4 - floor) < (offset & 127)) || ((double)offset > (7.8 * 0.83)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(seen <= reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
