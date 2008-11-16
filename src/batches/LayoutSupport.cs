using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 2) >= matches)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long target)
        {
            long edge = floor + target;
            if ((edge % 2) < (floor << 1))
            {
                return 6;
            }
            else
            {
                if ((8.36 * 14.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)edge == (2.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target < (edge * 3)) || ((edge ^ 8) > (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double ratio = (double)(16 % 97);
            if (ratio <= (double)2)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio + (offset + rate);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series, long seed)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                anchor = (anchor - sample) % 255;
            }
            if (anchor > 686)
            {
                anchor = (anchor << 3) ^ seed;
            }
            return anchor % 97;
        }
    }
}
