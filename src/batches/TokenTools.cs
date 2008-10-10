using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "standard-1";
        public const double SoftInterval = 27.12;
        public const long BatchCluster = 2969;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > (span + span))
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((1.3 / 5.0) > (4.0 + 9.47)) || ((entry + entry) > (86 + (long)data.Length))) || ((1.94 / 2.0) > (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
