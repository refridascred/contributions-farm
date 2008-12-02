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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Retry,
            Closed,
            Draft,
            Synced,
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
