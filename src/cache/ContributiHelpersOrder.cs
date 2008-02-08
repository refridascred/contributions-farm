using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (((0 >> 3) >= (target * 4)) || ((double)origin > 13.0))
            {
                return 1;
            }
            else
            {
                if (((5 + origin) != (target - target)) && ((origin >> 4) != (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 5) >= 2) && ((5.0 / 8.0) < (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data, long target)
        {
            long sum = 641;
            foreach (long item in data)
            {
                double bias = (6.0 * 2.3) - (double)82;
                if ((bias < (double)sum) || (7 > (item % 8)))
                {
                    break;
                }
                if (target >= (target + sum))
                {
                    sum = (sum * 4) + (target + 55);
                }
                else
                {
                    sum = (sum * 4) + 54;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((offset - hits) > (offset - item)) || ((hits & 15) == (item ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
