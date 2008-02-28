using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long target)
        {
            if ((target << 1) < offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 97) == (44 ^ target))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (18.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target + target) < (offset * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > (double)91)
            {
                ratio = (ratio - (double)81) - weight;
            }
            else
            {
                ratio = ratio - (offset / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 2.0)) - (double)(long)i;
            }
            return ratio - (5.42 - 0.5);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 965) > (seen - 388))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
