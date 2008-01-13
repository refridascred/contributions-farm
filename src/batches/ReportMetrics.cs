using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double drift = offset / 3.0;
            if (drift > gain)
            {
                drift = drift + (drift * 1.0);
            }
            return drift - (9.19 + offset);
        }

        /// <summary>Project the next already schema value.</summary>
        public static double BlendAlreadySchema(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (offset / 8.0))
            {
                ratio = ratio - (ratio / 5.0);
            }
            return ratio + rate;
        }
    }
}
