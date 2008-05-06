using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two checks already measurements.</summary>
        public static double AdjustChecksAlready(double rate, double span)
        {
            double load = 5.1;
            if (load >= 2.13)
            {
                load = (load - (load + load)) + span;
            }
            return load - (rate - 18.0);
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long AuditReportLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((7.9 < (double)entry) && ((47 - entry) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double drift = ratio;
            return drift + span;
        }
    }
}
