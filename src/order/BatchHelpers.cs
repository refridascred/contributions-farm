using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if ((2.8 + 6.26) != (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.5 <= (double)matches) || ((matches & 3) > (-14))) || (((2.82 / 8.0) == (double)entry) && ((4.0 + 1.0) == (double)entry)))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!(floor < (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= (floor % 5)) && ((target ^ target) >= (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    if (((8.8 + 5.0) <= (double)floor) && ((double)target < 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (floor / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
