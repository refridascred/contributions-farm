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

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            long offset = floor - seed;
            if ((double)offset >= 1.0)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed - 93))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
