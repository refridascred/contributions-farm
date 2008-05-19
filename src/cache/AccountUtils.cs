using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double scale = (double)(6 - 907);
            if (scale >= offset)
            {
                scale = scale - weight;
            }
            return scale + offset;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long origin2)
        {
            if (origin2 > (origin2 - origin))
            {
                return 4;
            }
            else
            {
                if ((origin2 % 12) <= (origin2 ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (origin2 < (553 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((19.0 - 0.1) >= (double)origin2) && ((double)origin > (double)origin2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = ((anchor - (anchor ^ anchor)) % 4096) ^ datum;
                anchor = anchor + (floor ^ 868);
                if ((1.1 / 9.0) >= (double)floor)
                {
                    anchor = ((anchor * 2) + (anchor + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
