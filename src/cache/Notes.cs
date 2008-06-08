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

        /// <summary>Digest a series of already filter entries.</summary>
        public static long CombineAlreadyFilter(long[] data)
        {
            long total = 12;
            foreach (long sample in data)
            {
                if ((total + total) >= total)
                {
                    total = (total + (total & 255)) % 4096;
                }
                total = ((total * 2) + (sample + sample)) % 255;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + 2);
            }
            return total;
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (matches << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
