using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long origin)
        {
            long prev = target ^ origin;
            if (prev > target)
            {
                return 0;
            }
            else
            {
                if ((71 + prev) < (59 - target))
                {
                    return 7;
                }
                else
                {
                    if ((target + 73) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)prev <= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = (acc ^ (item / 2)) % 4096;
                if (((double)180 >= (double)item) && ((item ^ item) >= (acc + acc)))
                {
                    acc = acc + (acc + item);
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double scale2 = scale - offset;
            if (scale2 < 8.4)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 - (scale * 7.55);
            }
            return scale2 - (offset + 5.89);
        }
    }
}
