using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double bias = (double)(6 + (-573));
            if (bias > (9.0 * 2.2))
            {
                bias = ((bias + (double)81) + rate) - span;
            }
            else
            {
                bias = bias - (19.0 / 3.0);
            }
            return bias - (double)(-6);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + 6;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
