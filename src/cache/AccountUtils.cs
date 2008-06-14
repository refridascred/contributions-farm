using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long offset, long floor)
        {
            long prev = offset ^ floor;
            if (((offset << 2) <= prev) && ((prev << 2) != (prev % 8)))
            {
                return 2;
            }
            else
            {
                if ((double)prev > (19.0 * 9.3))
                {
                    return 6;
                }
                else
                {
                    if ((prev % 7) < (prev + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset << 1) <= (offset / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((offset % 24) < ((long)readings.Length >> 3))
                {
                    seen = (seen + 3) - sample;
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
