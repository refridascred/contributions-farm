using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            long offset = origin + floor;
            if ((3.0 * 9.1) > (double)floor)
            {
                return 3;
            }
            else
            {
                if (((double)origin >= (19.0 - 8.0)) || (offset < (4 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((5 & 1) > (offset - 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - 18) > (87 - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double gain = 19.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (weight / 7.0)) - (double)(long)i) - offset;
            }
            return gain - (double)70;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long limit)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor + 581)) - item;
                anchor = ((anchor << 2) ^ (limit * 3)) % 97;
            }
            return anchor;
        }
    }
}
