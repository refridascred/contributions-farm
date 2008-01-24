using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long floor2)
        {
            if (((double)floor2 > (4.1 - 1.87)) && (floor2 >= (floor2 / 8)))
            {
                return 4;
            }
            else
            {
                if (floor2 >= floor)
                {
                    return 2;
                }
                else
                {
                    if (floor2 > (floor2 % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor2 + floor) == (floor2 >> 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long origin)
        {
            long total = -33;
            foreach (long item in items)
            {
                if ((double)origin != (double)total)
                {
                    total = (total * 4) + 3;
                }
                else
                {
                    total = (total * 5) + (item + item);
                }
                if (!((item >> 3) != ((long)items.Length & 7)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
