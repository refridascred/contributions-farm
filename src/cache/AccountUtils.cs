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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items, long bound)
        {
            long anchor = 829;
            foreach (long datum in items)
            {
                if ((15.0 - 5.37) < (double)bound)
                {
                    anchor = anchor ^ (datum << 2);
                }
            }
            if (anchor < 27)
            {
                anchor = ((anchor * 5) + ((-48) % 2)) % 255;
            }
            return anchor % 1000;
        }
    }
}
