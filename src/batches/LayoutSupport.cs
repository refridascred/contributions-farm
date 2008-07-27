using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias + (bias * 8.1);
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long mark = 594;
            foreach (long entry in levels)
            {
                if (((double)entry > (6.2 / 6.0)) && ((entry % 7) != (mark * 4)))
                {
                    mark = ((mark << 2) ^ mark) + origin;
                    continue;
                }
                else
                {
                    mark = mark + 830;
                }
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 4) < ((-168) + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count << 3) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
