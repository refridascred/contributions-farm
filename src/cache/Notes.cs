using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            if ((double)origin2 != (4.93 - 6.65))
            {
                return 2;
            }
            else
            {
                if (origin2 < (origin2 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((32 <= origin) && ((3.33 * 7.38) > (double)origin2))
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

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = offset;
            if (mean > (mean * 19.0))
            {
                mean = mean + (double)9;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Roll a counter checks counter forward.</summary>
        public static long StepCounterChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + ((long)i << 3)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if (((double)offset2 >= (3.13 - 9.3)) && ((limit >> 1) >= (offset2 / 6)))
            {
                return 4;
            }
            else
            {
                if ((offset2 < (offset % 8)) && ((double)offset <= (2.0 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            if (2 >= (offset ^ 1))
            {
                return 2;
            }
            else
            {
                if (0 >= offset2)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
