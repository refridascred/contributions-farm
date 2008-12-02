using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long floor)
        {
            long lane = limit + floor;
            if ((floor <= (lane & 63)) && ((floor * 3) < limit))
            {
                return 2;
            }
            else
            {
                if (888 <= (lane + (-655)))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 2) > (limit - floor))
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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!!((double)875 > (double)floor))
                {
                    mark = ((mark << 2) ^ ((long)i + floor)) % 65521;
                }
                mark = ((mark * 3) + (floor / 5)) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a notes cache counter forward.</summary>
        public static long StepNotesCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (194 >> 3)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
