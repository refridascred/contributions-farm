using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.0 * 7.48) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
