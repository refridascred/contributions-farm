using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = (bias + offset) - scale;
            }
            return bias - (offset - 1.3);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long total = 83;
            foreach (long value in levels)
            {
                if ((total - target) <= (total & 63))
                {
                    total = ((total - (79 * 2)) % 255) ^ value;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long anchor = 431;
            foreach (long item in data)
            {
                if (!((item + anchor) > item))
                {
                    anchor = anchor - (anchor >> 5);
                }
            }
            return anchor;
        }
    }
}
