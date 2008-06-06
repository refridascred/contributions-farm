using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of order window entries.</summary>
        public static long FoldOrderWindow(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if ((800 >> 1) >= (anchor + bound))
                {
                    anchor = (((anchor << 3) ^ (bound % 3)) % 255) + item;
                }
            }
            return anchor;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double load = span;
            if (load < gain)
            {
                load = load + load;
            }
            return load + span;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = 28;
            foreach (long cell in values)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = ((anchor + (anchor << 3)) % 101) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 * 3) > (datum - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
