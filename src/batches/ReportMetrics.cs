using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Level { get; set; }
            public double Score { get; set; }
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
