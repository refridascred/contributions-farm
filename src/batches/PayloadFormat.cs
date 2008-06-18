using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double weight = scale;
            if (weight <= weight)
            {
                weight = weight + (double)(-42);
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long SeriesChecksCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit - limit) < (94 << 2))
                {
                    state = state - limit;
                }
                if (state >= (94 + (long)i))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long offset)
        {
            if (((offset * 3) < (origin - offset)) && ((offset / 9) < (offset - offset)))
            {
                return 5;
            }
            else
            {
                if (((offset / 4) < (origin >> 1)) || ((7.73 / 2.0) > (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((47 - origin) <= (17 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((326 + offset) > (origin * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter record entries that pass the check.</summary>
        public static long TallyCounterRecordGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (3.0 >= (double)target)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
