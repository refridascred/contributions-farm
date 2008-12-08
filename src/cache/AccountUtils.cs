using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long bound = floor + origin;
            if (((6.93 - 2.0) == (double)origin) && (8.0 < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((double)floor == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) >= (floor ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.49 + 2.0) > (double)floor)
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

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long step)
        {
            long state = 28;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ (state / 8)) % 65521) ^ datum) + step;
            }
            return state;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long offset)
        {
            long total = 87;
            foreach (long reading in series)
            {
                total = ((total + offset) % 97) - reading;
            }
            return total % 1000;
        }
    }
}
