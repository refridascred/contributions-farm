using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double offset)
        {
            double scale = (double)46 + (6.79 - offset);
            if (scale < (double)22)
            {
                scale = scale - (bias / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (offset - offset)) + (double)(long)i;
            }
            return scale - (12.0 / 5.0);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit session format readings against a rule.</summary>
        public static long CountSessionFormatOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading & 7) > seen) || (reading < (6 - 79)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
