using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long floor)
        {
            if (6 < origin)
            {
                return 7;
            }
            else
            {
                if ((floor - 380) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (((floor << 2) <= (floor - floor)) || ((floor / 6) > (floor % 12)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((715 << 3) == (7 - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
